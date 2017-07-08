
using Domain.Entities.Base;
using Infrastructure.Log;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using Repository.Contexts;

namespace Repository.Repositories.BaseRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected static ILogHelper log;

        private DbContext Context { get; set; }

        public GenericRepository()
        {
            IDbContextFactory dbContextFactory = new DbContextFactory();
            Context = dbContextFactory.GetDbContext();
            log = new LogHelper();
        }

        public void SetContext(DbContext dbContext)
        {
            Context = dbContext;
            log = new LogHelper();
        }

        public DbContext GetContext()
        {
            return Context;
        }
        public virtual IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public virtual IQueryable<T> FindAllBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public virtual T FindFirstBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().FirstOrDefault(predicate);
        }

        public virtual void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual void Delete(IQueryable<T> entities)
        {
            foreach (T entity in entities.ToList())
                Context.Set<T>().Remove(entity);
            Context.SaveChanges();
         
        }

        public virtual void Edit(IQueryable<T> entities)
        {
            foreach (T entity in entities.ToList())
                Context.Entry(entity).State = EntityState.Modified;

            Context.SaveChanges();
        }

        public virtual void Edit(T entity)
        {
            try
            {
                Context.Entry(entity).State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                LogDbEntityErrors(dbEx);
            }
            catch (Exception ex)
            {
                log.Error("Save failed", ex);
            }
        }

        public virtual int Save()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                LogDbEntityErrors(dbEx);
            }
            catch (Exception ex)
            {
                log.Error("Save failed", ex);
            }
            return 0;
        }

        public virtual int Save(T entity)
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
                return entity.Id;
            }
            catch (DbEntityValidationException dbEx)
            {
                LogDbEntityErrors(dbEx);
            }
            catch (Exception ex)
            {
                //log.Error("Save failed", ex);
                throw new Exception(ex.Message);
            }
            return 0;
        }

      

        private static void LogDbEntityErrors(DbEntityValidationException dbEx)
        {
            foreach (var validationErrors in dbEx.EntityValidationErrors)
            {
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    throw new Exception(string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                    //log.Error(string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                }
            }
        }

        public virtual T Find(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Refresh(T entity)
        {
            Context.Entry(entity).Reload();
        }

        public virtual int Count()
        {
            return Context.Set<T>().Count();
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}

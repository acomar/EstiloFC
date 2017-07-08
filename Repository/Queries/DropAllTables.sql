DECLARE @Tabela TABLE (Seq INT, Id INT, Name sysname);
 DECLARE @Loop INT, @Qt INT;
 
 -- Enquanto existir foreignkey Excluir os objetos que não são referenciados
WHILE
  (SELECT COUNT(*) FROM sys.foreign_keys) > 0 
  BEGIN
	DELETE @Tabela;
 
SET @Loop = 1;
 
INSERT INTO @Tabela
SELECT ROW_NUMBER() OVER(ORDER BY t.Name) AS Seq,
       t.object_id AS Id,
       t.name
FROM sys.tables t;
 
 
SET @Qt = @@ROWCOUNT;
 
 WHILE @Loop <= @Qt BEGIN DECLARE @sql VARCHAR(100) = '';
 
 IF NOT EXISTS
  (SELECT 1
   FROM sys.foreign_keys fk
   WHERE fk.referenced_object_id =
       (SELECT Id
        FROM @Tabela o
        WHERE o.Seq = @Loop)) BEGIN
SELECT @sql = 'DROP TABLE ' + o.name
FROM @Tabela o
WHERE o.Seq = @Loop;
 
 PRINT 'Droping ' + @sql;
 
 EXECUTE(@sql);
 
 END;
 
 
SET @Loop = @Loop +1;
 
 END;
 
 END;
 
 -- Por garantia executa mais um drop geral, pois pode restar tabelas
EXEC sp_MSforeachtable 'DROP TABLE ?; ' ;
 
 GO
 drop table [ProductCategory]
 drop table [Contact]
 drop table [State]
 drop table [City]
 drop table [gender]
 drop table [Address]
 drop table [OrderStatus]
 drop table [order]
 drop table [user]
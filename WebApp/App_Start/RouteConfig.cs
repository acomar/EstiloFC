using Application.Services;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            HomeMapRoute(routes);
            AccountMapRoute(routes);
            MenuMapRoute(routes);
            ContactUsMapRoute(routes);
            InstitucionalMapRoute(routes);
            FrequentlyAskedMapRoute(routes);
            BasketMapRoute(routes);
            DetailRoute(routes);
            OrderRoute(routes);
            ExchangesRoute(routes);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        private static void ExchangesRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Troca-e-devolucao",
                url: "Help/Exchanges",
                defaults: new { controller = "Help", action = "Exchanges" }
            );
        }
        private static void OrderRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "MeusPedidos",
                url: "MeusPedidos",
                defaults: new { controller = "Order", action = "ViewOrders" }
            );
        }

        private static void DetailRoute(RouteCollection routes)
        {
            var productRepository = new GenericRepository<Product>();
            foreach (var item in productRepository.FindAllBy(p => p.Active))
            {
                routes.MapRoute(
                   name: string.Format("Detalhe{0}", item.Id),
                   url: string.Format("{0}{1}",item.NameForRoute,item.ComplementName),
                   defaults: new { controller = "Product", action = "Detail", id = item.Id }
               );

            }
        }

        private static void HomeMapRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        private static void AccountMapRoute(RouteCollection routes)
        {
            routes.MapRoute(
              name: "Cadastrar",
              url: "Cadastrar",
              defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Editar",
                url: "Editar",
                defaults: new { controller = "Account", action = "RegisterEdit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RecuperarSenha",
                url: "RecuperarSenha",
                defaults: new { controller = "Account", action = "ForgotPassword", id = UrlParameter.Optional }
            );
        }
        private static void MenuMapRoute(RouteCollection routes)
        {
            SideMenuService menuService = new SideMenuService(new GenericRepository<ProductCategory>());
            SideMenuViewModel sideMenuViewModel = menuService.GetViewModel();

            foreach (var menu in sideMenuViewModel.Menu)
            {
                foreach (var item in menu.ProductCategoryChields)
                {
                    routes.MapRoute(
                       name: string.Format("{0}{1}", item.RootCategory.Name, item.Name),
                       url: string.Concat(item.RootCategory.NameForRoute, "/{nameCategory}/{searchText}"),
                       defaults: new { controller = "Home", action = "Index", nameRootCategory = item.RootCategory.Name, nameCategory = UrlParameter.Optional, SearchText = UrlParameter.Optional });

                };
            };
        }
        private static void ContactUsMapRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Contato",
                url: "Contato",
                defaults: new { controller = "ContactUs", action = "Index" }
            );
        }
        private static void InstitucionalMapRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Politica-de-Privacidade",
                url: "Institucional/Politica-de-Privacidade",
                defaults: new { controller = "Institutional", action = "PrivacyPolicy" }
            );

            routes.MapRoute(
                name: "InstitucionalSobre",
                url: "Institucional/Sobre",
                defaults: new { controller = "Institutional", action = "About" }
            );

            routes.MapRoute(
                name: "Institucional/TermoDeUso",
                url: "Institucional/Termo-de-Uso",
                defaults: new { controller = "Institutional", action = "TermsOfUse" }
            );
        }
        private static void FrequentlyAskedMapRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "PerguntasFrequentes",
                url: "Perguntas-Frequentes",
                defaults: new { controller = "FrequentlyAsked", action = "Index" }
            );
        }
        private static void BasketMapRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "sacola",
                url: "sacola",
                defaults: new { controller = "Basket", action = "Index" }
            );
        }
    }
}
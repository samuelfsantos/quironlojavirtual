using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1 - Início: "/" - Produtos de todas as categorias
            routes.MapRoute(
                null,
                "",
                new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null, pagina = 1 }
            );

            // 2 - Segundo: "/Pagina2" - Todas as categorias da página 2
            routes.MapRoute(
                null,
                "Pagina{pagina}",
                new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null }, new { pagina = @"\d+" }
            );

            // 3 - Terceiro: "/Futebol" - Primeira página da categoria futebol
            routes.MapRoute(
                null,
                "{categoria}",
                new { controller = "Vitrine", action = "ListaProdutos", pagina = 1}
            );

            // 4 - Quarto: "/Futebol/Pagina2" - Página 2 da categoria futebol
            routes.MapRoute(
                null,
                "{categoria}/Pagina{pagina}",
                new { controller = "Vitrine", action = "ListaProdutos" }, new { pagina = @"\d+" }
            );

            routes.MapRoute(null, "{controller}/{action}");

            ////routes.MapRoute(
            ////    name: "Default",
            ////    url: "{controller}/{action}/{id}",
            ////    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            ////);
        }
    }
}

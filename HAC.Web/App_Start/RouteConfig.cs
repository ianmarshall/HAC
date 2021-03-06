﻿using System.Web.Mvc;
using System.Web.Routing;

namespace HAC.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           "LatestComments", // Nombre de ruta
           "Comment/Latest/{top}", // URL con parámetros
           new { controller = "Comment", action = "Latest", top = 10 } // Valores predeterminados de parámetro
      );

            routes.MapRoute(
            "ImageView", // Nombre de ruta
            "ImageView", // URL con parámetros
            new { controller = "Image", action = "View", ImageVPath = UrlParameter.Optional } // Valores predeterminados de parámetro
          );


            routes.MapRoute(
            "ThumbnailView", // Nombre de ruta
            "ThumbnailView/{width}/{height}", // URL con parámetros
            new { controller = "Image", action = "Thumbnail", width = "100", height = "100", ImageVPath = UrlParameter.Optional } // Valores predeterminados de parámetro
            );


            routes.MapRoute(
            "ImageMain", // Nombre de ruta
            "Image", // URL con parámetros
            new { controller = "PGImage", action = "Index", ImageVPath = UrlParameter.Optional } // Valores predeterminados de parámetro
            );


            routes.MapRoute(
                            "Image", // Nombre de ruta
                            "Image/{id}", // URL con parámetros
                            new { controller = "PGImage", action = "Index", id = UrlParameter.Optional } // Valores predeterminados de parámetro
                            );
            routes.MapRoute(
             "MainFolderList", // Nombre de ruta
             "Main/Folder/List/{folder}", // URL con parámetros
             new { controller = "PGFolder", action = "List", folder = UrlParameter.Optional } // Valores predeterminados de parámetro
         );


            routes.MapRoute(
                "FolderList", // Nombre de ruta
                "Folder/List/{folder}", // URL con parámetros
                new { controller = "PGFolder", action = "List", folder = UrlParameter.Optional } // Valores predeterminados de parámetro
            );


            routes.MapRoute(
               "PhotosCategoryList", // Nombre de ruta
               "PHOTOS/Category/List/{iCat}", // URL con parámetros
               new { controller = "Category", action = "List", iCat = 0 } // Valores predeterminados de parámetro
           );

            routes.MapRoute(
              "NewsDetails", // Nombre de ruta
              "News/Details/{Id}", // URL con parámetros
              new { controller = "News", action = "Details", id = 0 } // Valores predeterminados de parámetro
          );

            routes.MapRoute(
              "CategoryList", // Nombre de ruta
              "Category/List/{iCat}", // URL con parámetros
              new { controller = "Category", action = "List", iCat = 0 } // Valores predeterminados de parámetro
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
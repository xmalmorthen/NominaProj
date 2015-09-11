﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Mvc;

namespace wsNomina
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           
            config.Routes.MapHttpRoute(
                "reports",
                "apiV1/{action}",
                new
                {
                    controller = "reports"
                },
                new { httpMethod = new HttpMethodConstraint(System.Net.Http.HttpMethod.Get) }
            );

            config.Routes.MapHttpRoute("dashboard","apiV1/{action}/{id}",new{controller = "dashboard",id = RouteParameter.Optional});
            

            // Quite los comentarios de la siguiente línea de código para habilitar la compatibilidad de consultas para las acciones con un tipo de valor devuelto IQueryable o IQueryable<T>.
            // Para evitar el procesamiento de consultas inesperadas o malintencionadas, use la configuración de validación en QueryableAttribute para validar las consultas entrantes.
            // Para obtener más información, visite http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // Para deshabilitar el seguimiento en la aplicación, incluya un comentario o quite la siguiente línea de código
            // Para obtener más información, consulte: http://www.asp.net/web-api
            config.EnableSystemDiagnosticsTracing();
        }
    }
}

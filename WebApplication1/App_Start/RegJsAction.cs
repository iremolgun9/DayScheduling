using System;

[assembly: WebActivator.PreApplicationStartMethod(
    typeof(WebApplication1.App_Start.RegJsAction), "PreStart")]

namespace WebApplication1.App_Start {
    public static class RegJsAction {
        public static void PreStart() {
            System.Web.Routing.RouteTable.Routes.Add("JsActionRoute", JsAction.JsActionRouteHandlerInstance.JsActionRoute);
        }
    }
}

using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace amp_access
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //hcb.Response.AppendHeader("AMP-Access-Control-Allow-Source-Origin", string.Format("{0}://{1}", hcb.Request.Url.Scheme, hcb.Request.Url.Authority));
            //HttpContext.Current.Response.AddHeader("AMP-Access-Control-Allow-Source-Origin", "http://localhost:3742");
            //HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
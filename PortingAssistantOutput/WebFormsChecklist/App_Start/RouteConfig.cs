using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.FriendlyUrls;
using Microsoft.AspNetCore.Components;

namespace WebFormsChecklist
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
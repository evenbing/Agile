﻿using Agile.Web.Framework.Mvc.Routing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agile.Plugin.WechatPay.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapAreaControllerRoute(name: "areaRoute", "wechatPay", pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");
        }

        public int Priority => 0;
    }
}

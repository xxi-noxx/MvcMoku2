using FilterApplication.ViewEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FilterApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			// ViewEngineをCShape（.cshtml）だけ読むように設定
			ViewEngines.Engines.Clear();
			ViewEngines.Engines.Add(new CShapeOnlyViewEngine());
        }
    }
}

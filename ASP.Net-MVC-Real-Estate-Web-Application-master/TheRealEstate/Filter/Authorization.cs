using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheReaLState.Filter
{
    public class Authorization : System.Web.Mvc.ActionFilterAttribute, System.Web.Mvc.IActionFilter
    {
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["IsLogedIn"] == null)
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                {
                    {"Controller", "SignUp"},
                    {"Action", "SignIn"}
                });

            }
            base.OnActionExecuting(filterContext);
        }
    }

    public class AuthorizedAdmin : System.Web.Mvc.ActionFilterAttribute, System.Web.Mvc.IActionFilter
    {
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["AdminIsLogedIn"] == null)
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                {
                    {"Controller", "Home"},
                    {"Action", "Index"}
                });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
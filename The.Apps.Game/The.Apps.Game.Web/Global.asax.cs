using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using The.Apps.Game.Core.Logger;
using The.Apps.Game.Web.App_Start;
using The.Apps.Game.Web.Identity;

namespace The.Apps.Game.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ContainerConfig.ConfigureContainer();
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie authCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie == null || authCookie.Value == "")
                return;

            FormsAuthenticationTicket ticket;
            try
            {
                ticket = FormsAuthentication.Decrypt(authCookie.Value);
            }
            catch (Exception exception)
            {
                Log.Error("Application_AuthenticateRequest failed during encrypting cookie.", exception);
                return;
            }

            if (ticket != null)
            {
                var splitBySections = ticket.UserData.Split(',');
                var displayName = splitBySections[0];
                var roles = splitBySections[1].Split(';');
                var identity = new ExtendedGenericIdentity(ticket.Name, displayName);
                Thread.CurrentPrincipal = new GenericPrincipal(identity, roles);
                Context.User = Thread.CurrentPrincipal;
                //if (Context.User != null)
                //{                    
                //    Context.User = new GenericPrincipal(Context.User.Identity, roles);
                //}
            }
        }
    }
}

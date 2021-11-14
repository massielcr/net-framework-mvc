using LifeCycle.Controllers;
using LifeCycle.Services;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace LifeCycle.Extensions
{
    public class ParameterControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            return controllerName.ToLower() == "parameter" ? (IController)new ParameterController(new Logger()) : new HomeController();
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {

        }
    }
}
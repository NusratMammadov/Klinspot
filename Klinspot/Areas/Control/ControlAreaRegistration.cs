using System.Web.Mvc;

namespace Klinspot.Areas.Control
{
    public class ControlAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Control";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Control_default",
                "Control/{controller}/{action}/{id}",
                new { controller="auth", action = "login", id = UrlParameter.Optional },
                new[] { "Klinspot.Areas.Control.Controllers" }
            );
        }
    }
}
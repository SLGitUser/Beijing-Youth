using System.Web.Mvc;

namespace BeijingYouth.Web.Areas.BZWD
{
    public class BZWDAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BZWD";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BZWD_default",
                "BZWD/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
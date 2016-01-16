using System.Web.Mvc;

namespace BeijingYouth.Web.Areas.YP
{
    public class YPAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "YP";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "YP_default",
                "YP/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
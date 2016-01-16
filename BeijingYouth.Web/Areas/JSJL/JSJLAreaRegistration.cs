using System.Web.Mvc;

namespace BeijingYouth.Web.Areas.JSJL
{
    public class JSJLAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "JSJL";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "JSJL_default",
                "JSJL/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
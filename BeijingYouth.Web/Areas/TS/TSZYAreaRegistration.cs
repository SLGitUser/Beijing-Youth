using System.Web.Mvc;

namespace BeijingYouth.Web.Areas.TSZY
{
    public class TSZYAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TSZY";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TSZY_default",
                "TSZY/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
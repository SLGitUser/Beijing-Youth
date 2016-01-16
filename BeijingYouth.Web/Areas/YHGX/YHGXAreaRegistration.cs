using System.Web.Mvc;

namespace BeijingYouth.Web.Areas.YHGX
{
    public class YHGXAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "YHGX";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "YHGX_default",
                "YHGX/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
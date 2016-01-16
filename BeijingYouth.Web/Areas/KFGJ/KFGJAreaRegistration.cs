using System.Web.Mvc;

namespace BeijingYouth.Web.Areas.KFGJ
{
    public class KFGJAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "KFGJ";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "KFGJ_default",
                "KFGJ/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
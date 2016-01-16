using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeijingYouth.Web.Startup))]
namespace BeijingYouth.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

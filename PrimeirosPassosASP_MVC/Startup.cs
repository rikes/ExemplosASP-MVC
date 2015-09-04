using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeirosPassosASP_MVC.Startup))]
namespace PrimeirosPassosASP_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetPostModel.Startup))]
namespace GetPostModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

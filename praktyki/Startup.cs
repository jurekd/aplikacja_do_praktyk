using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(praktyki.Startup))]
namespace praktyki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;
using TheGym.Website;

[assembly: OwinStartup(typeof(Startup))]
namespace TheGym.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

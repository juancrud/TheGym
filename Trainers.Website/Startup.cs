using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trainers.Website.Startup))]
namespace Trainers.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

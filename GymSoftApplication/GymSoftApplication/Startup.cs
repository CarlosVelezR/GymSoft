using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymSoftApplication.Startup))]
namespace GymSoftApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

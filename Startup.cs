using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FawazWebApp1.Startup))]
namespace FawazWebApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

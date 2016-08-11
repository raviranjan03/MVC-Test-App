using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_Application.Startup))]
namespace Demo_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zoologico.application.Startup))]
namespace Zoologico.application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Panaderia.Startup))]
namespace Panaderia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

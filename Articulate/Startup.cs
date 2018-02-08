using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Articulate.Startup))]
namespace Articulate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stori.Startup))]
namespace Stori
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

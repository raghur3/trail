using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reval.Startup))]
namespace Reval
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

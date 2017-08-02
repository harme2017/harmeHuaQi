using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(harmeHuaQi.Startup))]
namespace harmeHuaQi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

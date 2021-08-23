using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UrnikGooG_UporabnikClient.Startup))]
namespace UrnikGooG_UporabnikClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesManagementOnline.Startup))]
namespace SalesManagementOnline
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

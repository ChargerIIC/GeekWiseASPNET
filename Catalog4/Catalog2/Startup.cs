using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Catalog2.Startup))]
namespace Catalog2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

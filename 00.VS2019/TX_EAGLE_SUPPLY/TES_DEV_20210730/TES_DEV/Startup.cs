using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TES_DEV.Startup))]
namespace TES_DEV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TES.Startup))]
namespace TES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

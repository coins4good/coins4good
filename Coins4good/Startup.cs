using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coins4good.Startup))]
namespace Coins4good
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

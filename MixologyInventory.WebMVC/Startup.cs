using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MixologyInventory.WebMVC.Startup))]
namespace MixologyInventory.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JDeanShoppingApp.Startup))]
namespace JDeanShoppingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

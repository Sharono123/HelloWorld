using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebAppHelloWorld.Startup))]
namespace AzureWebAppHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebOne.Startup))]
namespace AzureWebOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

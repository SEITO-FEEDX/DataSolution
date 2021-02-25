using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppBackend.Startup))]
namespace WebAppBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

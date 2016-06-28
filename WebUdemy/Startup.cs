using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebUdemy.Startup))]
namespace WebUdemy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

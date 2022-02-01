using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP220131_v1.Startup))]
namespace ASP220131_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

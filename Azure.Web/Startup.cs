using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure.Web.Startup))]
namespace Azure.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

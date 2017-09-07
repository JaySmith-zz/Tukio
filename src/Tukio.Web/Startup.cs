using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tukio.Web.Startup))]
namespace Tukio.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

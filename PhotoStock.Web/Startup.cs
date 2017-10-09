using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoStock.Web.Startup))]
namespace PhotoStock.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

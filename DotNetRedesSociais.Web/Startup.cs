using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetRedesSociais.Web.Startup))]
namespace DotNetRedesSociais.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

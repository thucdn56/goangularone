using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoAngularOne.Web.Startup))]
namespace GoAngularOne.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMEWebsite.Startup))]
namespace SMEWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

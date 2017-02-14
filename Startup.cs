using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(patchmill.Startup))]
namespace patchmill
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

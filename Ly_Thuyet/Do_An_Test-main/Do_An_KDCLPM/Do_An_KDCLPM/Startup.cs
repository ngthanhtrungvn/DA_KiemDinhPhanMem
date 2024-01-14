using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Do_An_KDCLPM.Startup))]
namespace Do_An_KDCLPM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aykutasilComNet45.Startup))]
namespace aykutasilComNet45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

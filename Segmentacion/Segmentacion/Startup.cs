using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Segmentacion.Startup))]
namespace Segmentacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

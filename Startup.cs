using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigaByte.Startup))]
namespace GigaByte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

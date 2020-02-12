using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Midian.Startup))]
namespace Midian
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

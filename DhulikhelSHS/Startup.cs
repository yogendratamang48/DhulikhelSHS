using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DhulikhelSHS.Startup))]
namespace DhulikhelSHS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Northwest.Startup))]
namespace Northwest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

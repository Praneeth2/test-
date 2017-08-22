using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carol.Startup))]
namespace carol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

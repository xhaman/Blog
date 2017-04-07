using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcBot.Startup))]
namespace mvcBot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

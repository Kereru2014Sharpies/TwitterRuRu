using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterRuRu.Startup))]
namespace TwitterRuRu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

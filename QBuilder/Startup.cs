using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QBuilder.Startup))]
namespace QBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

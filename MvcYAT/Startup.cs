using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcYAT.Startup))]
namespace MvcYAT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgroCore.Startup))]
namespace AgroCore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

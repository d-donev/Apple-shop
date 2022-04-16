using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppleMania.Startup))]
namespace AppleMania
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

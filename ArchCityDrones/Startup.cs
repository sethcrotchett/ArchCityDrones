using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchCityDrones.Startup))]
namespace ArchCityDrones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

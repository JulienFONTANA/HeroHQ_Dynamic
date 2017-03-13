using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeroHQ_Dynamic.Startup))]
namespace HeroHQ_Dynamic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

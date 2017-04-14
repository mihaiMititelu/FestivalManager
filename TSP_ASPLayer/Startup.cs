using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TSP_ASPLayer.Startup))]
namespace TSP_ASPLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

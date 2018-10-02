using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunicationEngine.Startup))]
namespace CommunicationEngine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

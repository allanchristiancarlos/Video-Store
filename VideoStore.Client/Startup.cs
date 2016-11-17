using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoStore.Client.Startup))]
namespace VideoStore.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

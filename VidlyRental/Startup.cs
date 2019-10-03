using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyRental.Startup))]
namespace VidlyRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

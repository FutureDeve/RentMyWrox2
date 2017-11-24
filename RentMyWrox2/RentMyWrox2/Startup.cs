using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentMyWrox2.Startup))]
namespace RentMyWrox2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

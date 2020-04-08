using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blood_Donation.Startup))]
namespace Blood_Donation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

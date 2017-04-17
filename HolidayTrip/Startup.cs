using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HolidayTrip.Startup))]
namespace HolidayTrip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

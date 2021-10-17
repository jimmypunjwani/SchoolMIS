using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolMIS.Startup))]
namespace SchoolMIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(conf_report.Startup))]
namespace conf_report
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

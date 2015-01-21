using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeInformation.Web.Startup))]
namespace EmployeeInformation.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

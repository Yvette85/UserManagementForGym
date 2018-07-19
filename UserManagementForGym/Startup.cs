using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserManagementForGym.Startup))]
namespace UserManagementForGym
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

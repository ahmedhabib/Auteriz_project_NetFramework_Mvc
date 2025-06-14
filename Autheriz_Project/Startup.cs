using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autheriz_Project.Startup))]
namespace Autheriz_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

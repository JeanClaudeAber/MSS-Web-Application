using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSS.MVC.Startup))]
namespace MSS.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

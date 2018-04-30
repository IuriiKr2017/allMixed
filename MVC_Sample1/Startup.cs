using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Sample1.Startup))]
namespace MVC_Sample1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

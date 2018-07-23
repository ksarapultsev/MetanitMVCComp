using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloMVCApplication.Startup))]
namespace HelloMVCApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

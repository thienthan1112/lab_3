using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_3.Startup))]
namespace lab_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

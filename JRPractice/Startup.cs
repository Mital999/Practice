using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JRPractice.Startup))]
namespace JRPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

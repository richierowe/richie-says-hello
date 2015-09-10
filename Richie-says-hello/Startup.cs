using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Richie_says_hello.Startup))]
namespace Richie_says_hello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

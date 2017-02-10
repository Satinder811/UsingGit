using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsingGit.Startup))]
namespace UsingGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VAMotel.Startup))]
namespace VAMotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

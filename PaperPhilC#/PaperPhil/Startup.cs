using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaperPhil.Startup))]
namespace PaperPhil
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

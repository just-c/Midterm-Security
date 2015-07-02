using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MidtermSec.Startup))]
namespace MidtermSec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

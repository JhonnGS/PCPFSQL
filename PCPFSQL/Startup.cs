using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCPFSQL.Startup))]
namespace PCPFSQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

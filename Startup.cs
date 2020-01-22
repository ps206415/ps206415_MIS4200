using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ps206415_MIS4200.Startup))]
namespace ps206415_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

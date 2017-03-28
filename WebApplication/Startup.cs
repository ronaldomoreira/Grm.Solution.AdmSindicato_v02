using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdmSindWebAppV02.Startup))]
namespace AdmSindWebAppV02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

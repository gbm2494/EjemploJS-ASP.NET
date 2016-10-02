using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploJS.Startup))]
namespace EjemploJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

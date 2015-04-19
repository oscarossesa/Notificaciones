using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Notificaciones.Web.Startup))]

namespace Notificaciones.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
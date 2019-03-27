using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_Awesome_App.Startup))]
namespace SignalR_Awesome_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}

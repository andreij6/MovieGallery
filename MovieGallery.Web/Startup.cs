using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieGallery.Web.Startup))]
namespace MovieGallery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

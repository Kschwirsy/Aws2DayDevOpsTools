using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFavoriteMemesEB.Startup))]
namespace MyFavoriteMemesEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

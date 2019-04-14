using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipesBlog.Startup))]
namespace RecipesBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

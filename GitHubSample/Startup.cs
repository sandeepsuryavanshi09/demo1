using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubSample.Startup))]
namespace GitHubSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phamtiendung_2011062063bai3.Startup))]
namespace phamtiendung_2011062063bai3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

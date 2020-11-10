
using System.Web.Http;

namespace MasGlobal.HandsOnTest.Api
{

    public class WebApiApplication : System.Web.HttpApplication
    {
   
        protected void Application_Start()
        {
           GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

 
    }



}

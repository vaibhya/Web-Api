using System.Web.Http;
using WebApiOperationApp;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApiOperationApp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            Swashbuckle.Bootstrapper.Init(GlobalConfiguration.Configuration);

            // NOTE: If you want to customize the generated swagger or UI, use SwaggerSpecConfig and/or SwaggerUiConfig here ...
        }
    }
}
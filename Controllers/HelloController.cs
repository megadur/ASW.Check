using System.Web.Http;

namespace WebApiFramework.Controllers
{
    public class HelloController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
    }
}

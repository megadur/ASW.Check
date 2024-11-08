using ARZ_Check;
using ArzTI.Model;
using System.Collections.Generic;
using System.Web.Http;
using WebApiFramework.utilities;

namespace WebApiFramework.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class CheckApiController : ApiController
    {
        private static readonly Serilog.ILogger log = SerilogHelper._log;

        public CheckApiController()
        {

        }


        [HttpPost, Route("api/Check/Dispensierung")]
        public ICollection<Statusinfo> PostDispensierung([FromBody] string value)
        {
            log.Information("PostDispensierungAsync called with value: {value}", value);
            return ARZCheck.CheckRezept(value);

        }

    }

}
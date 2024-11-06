using ASW.Check.Controllers;
using ASW_Check.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace ASW_Check.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class CheckApiController : ApiController
    {
        private readonly CheckApiImpl _implementation;

        private CheckApiController()
        {
            _implementation = new CheckApiImpl();

        }
        public CheckApiController(CheckApiImpl implementation)
        {
            _implementation = implementation;
        }

        //[HttpPost(Name = "CheckPostDispensierung")]

        //public List<Statusinfo> CheckPostDispensierung(string? value = default, int operationIndex = 0)
        //{
        //    return _implementation.CheckPostDispensierung(value, operationIndex);
        //}


        [HttpPost, Route("api/Check/Dispensierung")]
        public Task<ICollection<Statusinfo>> PostDispensierung([FromBody] string value)
        {
            return _implementation.PostDispensierungAsync(value);
        }

        [HttpPost, Route("api/Check/DispensierungList")]
        public Task<ICollection<ICollection<Statusinfo>>> PostDispensierungList([FromBody] IEnumerable<string> values)
        {
            return _implementation.PostDispensierungListAsync(values);
        }

        [HttpPost, Route("api/Check/Rezept")]
        public Task<Rezept> PostRezept([FromBody] Rezept value)
        {
            return _implementation.PostRezeptAsync(value);
        }

        [HttpPost, Route("api/Check/RezeptList")]
        public Task<ICollection<Rezept>> PostRezeptList([FromBody] IEnumerable<Rezept> values)
        {
            return _implementation.PostRezeptList(values);


        }
    }

}
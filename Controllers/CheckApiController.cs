using ArzTI.Model;
using ASW.Check.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ASW_Check.Controllers
{
    //[ApiController]
    [Route("[controller]")]
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

        [HttpPut, HttpPost]
        public HttpResponseMessage Vis(HttpRequestMessage request)
        {
            //object idTerm = request.GetRouteData()?.Values["idTerm"];
            string x = request.Content.ReadAsStringAsync().Result;
            string responseMessage = "PUT/POST Vis for: " + x;
            return new HttpResponseMessage()
            {
                Content = new StringContent(responseMessage)
            };
        }
        [HttpPost, Route("api/Check/Dispensierung"),]
        public Task<ICollection<Statusinfo>> PostDispensierung([FromBody] StatusRequest value)
        {

            return _implementation.PostDispensierungAsync(value.Content);
        }

        [HttpPost, Route("api/Check/FileUpload"),]
        public string FileUpload(HttpPostedFileBase file)
        {
            _ = new HttpResponseMessage(HttpStatusCode.NotFound);
            if (file != null)
            {
                string extension = System.IO.Path.GetExtension(file.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                    string appendInfo = "data:image/" + extension + ";base64,";
                    string bufferData = appendInfo + Convert.ToBase64String(array);
                    return bufferData;
                }

            }
            // If you get here and have not returned, 
            // something went wrong and you should return an Empty
            return string.Empty;
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
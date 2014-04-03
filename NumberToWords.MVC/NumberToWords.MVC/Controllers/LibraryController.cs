using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NumberToWords.MVC.Controllers
{

    public class LibraryController : ApiController
    {
        [Route("api/library")]
        // GET api/library
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("api/library/{id:int}")]
        // GET api/library/5
        public string Get(int id)
        {
            return "value";
        }
    }
}

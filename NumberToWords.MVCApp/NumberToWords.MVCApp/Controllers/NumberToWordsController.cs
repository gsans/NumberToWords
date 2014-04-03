using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NumberToWords;

namespace NumberToWords.MVCApp.Controllers
{

    public class NumberToWordsController : ApiController
    {
        [Route("api/numbertowords/{number:int}")]
        // GET api/numbertowords/5
        public string Get(int number)
        {
            NumberToWords lib = new NumberToWords();
            return lib.Read(number);
        }
    }
}

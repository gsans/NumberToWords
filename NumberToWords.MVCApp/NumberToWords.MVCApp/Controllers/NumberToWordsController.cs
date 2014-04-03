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
        // GET api/numbertowords/5

        [Route("api/numbertowords/{number:int}")]        
        public string Get(int number)
        {
            NumberToWords lib = new NumberToWords();
            return lib.Read(number);
        }
    }
}

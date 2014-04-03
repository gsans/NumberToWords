using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public abstract class Parser
    {        
        protected Parser Successor { get; set; }
        public abstract void Parse(int number, StringBuilder numberInWords);
    }
}

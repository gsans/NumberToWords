using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class NumberParser : Parser
    {
        public NumberParser() 
        {
            Successor = new MillionsParser();
        }

        public override void Parse(int number, ref string output)
        {
            MillionsParser p = new MillionsParser();
            if (number < 0)
            {
                p.Parse(Math.Abs(number), ref output);
                output = "minus " + output;
                return;
            }            
            p.Parse(number, ref output);
        }
    }
}

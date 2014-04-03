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
        private const string MINUS = "minus";

        public NumberParser() 
        {
            Successor = new MillionsParser();
        }

        public override void Parse(int number, StringBuilder numberInWords)
        {            
            if (number < 0)
            {
                Successor.Parse(Math.Abs(number), numberInWords);
                numberInWords.AppendFormat("{0} ", MINUS);
                numberInWords.Append(numberInWords);
                return;
            }
            Successor.Parse(number, numberInWords);
        }
    }
}

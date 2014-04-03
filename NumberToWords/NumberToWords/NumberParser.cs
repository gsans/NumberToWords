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
                int positiveNumber;
                if (number == Int32.MinValue)
                    throw new ArgumentException(String.Format("Minimum value is: {0}", number - 1));
                else
                    positiveNumber = Math.Abs(number);
                numberInWords.AppendFormat("{0} ", MINUS);
                Successor.Parse(positiveNumber, numberInWords);
                return;
            }
            Successor.Parse(number, numberInWords);
        }
    }
}

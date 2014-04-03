using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class TensParser : Parser
    {
        private const int PARSER_BASE = 10;
        private const string AND = "and";

        private readonly string[] _units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private readonly string[] _tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public TensParser()
        {
            Successor = new UnitsParser();
        }
        public override void Parse(int number, StringBuilder numberInWords)
        {
            int head = number / PARSER_BASE;
            int tail = number % PARSER_BASE;

            // Appending to a larger number Eg: 1001
            if (!String.IsNullOrEmpty(numberInWords.ToString()))
                numberInWords.AppendFormat("{0} ", AND);

            if (number >= 20)
            {
                numberInWords.AppendFormat("{0}", _tens[head]);
                if (tail > 0)
                {
                    StringBuilder tailNumberInWords = new StringBuilder();
                    Successor.Parse(tail, tailNumberInWords);
                    numberInWords.AppendFormat(" {0}", tailNumberInWords.ToString());
                }
                return;
            }
            if (number>=10)
            {
                numberInWords.Append(_units[number]);
                return;
            }
            Successor.Parse(tail, numberInWords);                     
        }
    }
}

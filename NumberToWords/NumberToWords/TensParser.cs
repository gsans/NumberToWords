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

        private readonly string[] _units =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };
        private readonly string[] _tens =
        {
            "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        public TensParser()
        {
            Successor = new UnitsParser();
        }
        public override void Parse(int number, ref string output)
        {
            int division = number / PARSER_BASE;
            int reminder = number % PARSER_BASE;

            if (!String.IsNullOrEmpty(output))
                output += "and ";

            if (number >= 20)
            {
                output += _tens[division];
                if (reminder > 0)
                {
                    string units = string.Empty;
                    Successor.Parse(reminder, ref units);
                    output += "-" + units;
                }
                return;
            }
            if (number>=10)
            {
                output += _units[number];
                return;
            }
            Successor.Parse(reminder, ref output);                     
        }
    }
}

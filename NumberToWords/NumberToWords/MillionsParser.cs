using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class MillionsParser : Parser
    {
        private const int PARSER_BASE = 1000000;
        private const string MILLION = "million";

        public MillionsParser() 
        {
            Successor = new ThousandsParser();
        }
        public override void Parse(int number, ref string output)
        {
            int division = number / PARSER_BASE;
            int reminder = number % PARSER_BASE;

            if (division > 0)
            {
                NumberParser p = new NumberParser();
                string num = string.Empty;
                p.Parse(division, ref num);
                output += num + " " + MILLION;
                if (reminder == 0)
                    return;
                else
                    output += " ";
            }
            Successor.Parse(reminder, ref output);
        }
    }
}

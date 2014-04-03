using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class ThousandsParser : Parser
    {
        private const int PARSER_BASE = 1000;
        private const string THOUSAND = "thousand";

        public ThousandsParser()
        {
            Successor = new HundredsParser();
        }
        public override void Parse(int number, ref string output)
        {
            int division = number / PARSER_BASE;
            int reminder = number % PARSER_BASE;

            if (division > 0)
            {
                HundredsParser p = new HundredsParser();
                string units = String.Empty;
                p.Parse(division, ref units);
                output += units + " " + THOUSAND;
                if (reminder == 0)
                    return;
                else
                    output += " ";
            }
            Successor.Parse(reminder, ref output);         
        }

    }
}

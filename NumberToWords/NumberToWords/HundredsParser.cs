using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class HundredsParser : Parser
    {
        private const int PARSER_BASE = 100;
        private const string HUNDRED = "hundred";

        public HundredsParser()
        {
            Successor = new TensParser();
        }
        public override void Parse(int number, ref string output)
        {
            int division = number / PARSER_BASE;
            int reminder = number % PARSER_BASE;

            if (division > 0)
            {
                UnitsParser p = new UnitsParser();
                string units = String.Empty;
                p.Parse(division, ref units);
                output += units + " " + HUNDRED;
                if (reminder == 0)
                    return;
                else
                    output += " ";
            }
            Successor.Parse(reminder, ref output);
        }
    }
}

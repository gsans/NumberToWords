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
        public override void Parse(int number, StringBuilder numberInWords)
        {
            int head = number / PARSER_BASE;
            int tail = number % PARSER_BASE;

            if (head > 0)
            {
                UnitsParser p = new UnitsParser();
                StringBuilder headNumberInWords = new StringBuilder();
                p.Parse(head, headNumberInWords);
                numberInWords.AppendFormat("{0} {1}", headNumberInWords.ToString(), HUNDRED);
                if (tail > 0)
                    numberInWords.Append(" ");
                else
                    return;
            }
            Successor.Parse(tail, numberInWords);
        }
    }
}

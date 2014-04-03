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
        public override void Parse(int number, StringBuilder numberInWords)
        {
            int head = number / PARSER_BASE;
            int tail = number % PARSER_BASE;

            if (head > 0)
            {
                HundredsParser p = new HundredsParser();
                StringBuilder headNumberInWords = new StringBuilder();
                p.Parse(head, headNumberInWords);
                numberInWords.AppendFormat("{0} {1}", headNumberInWords.ToString(), THOUSAND);
                if (tail > 0)
                    numberInWords.Append(" ");
                else
                    return;
            }            
            Successor.Parse(tail, numberInWords);         
        }

    }
}

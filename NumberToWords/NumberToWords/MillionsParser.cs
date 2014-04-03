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
        public override void Parse(int number, StringBuilder numberInWords)
        {
            int head = number / PARSER_BASE;
            int tail = number % PARSER_BASE;

            if (head > 0)
            {
                NumberParser p = new NumberParser();
                StringBuilder headNumberInWords = new StringBuilder();
                p.Parse(head, headNumberInWords);
                numberInWords.AppendFormat("{0} {1}", headNumberInWords.ToString(), MILLION);
                if (tail > 0)
                    numberInWords.Append(" ");
                else
                    return;
            }            
            Successor.Parse(tail, numberInWords);
        }
    }
}

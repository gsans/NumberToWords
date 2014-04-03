using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class NumberToWords
    {
        private NumberParser _parser;

        public NumberToWords()
        {
            _parser = new NumberParser();
        }

        public string Read(int number)
        {            
            StringBuilder numberInWords = new StringBuilder();
            _parser.Parse(number, numberInWords);
            return numberInWords.ToString();
        }
    }
}

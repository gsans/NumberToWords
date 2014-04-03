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

        public string Read(int number)
        {
            string output = string.Empty;
            _parser = new NumberParser();
            _parser.Parse(number, ref output);
            return output;
        }
    }
}

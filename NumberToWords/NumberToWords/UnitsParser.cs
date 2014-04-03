using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class UnitsParser : Parser
    {
        private readonly string[] _units =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        public override void Parse(int number, ref string output)
        {
            output += _units[number];
        }
    }
}

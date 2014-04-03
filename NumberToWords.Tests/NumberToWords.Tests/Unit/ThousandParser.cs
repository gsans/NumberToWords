using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Unit
{
    [TestFixture]
    class ThousandsParserTests
    {
        [TestCase(1000, Result = "one thousand")]
        [TestCase(2000, Result = "two thousand")]
        [TestCase(3000, Result = "three thousand")]
        [TestCase(9000, Result = "nine thousand")]
        public string ThousandsParser_UnitsPlusHundred(int number)
        {
            string output = String.Empty;
            ThousandsParser parser = new ThousandsParser();
            parser.Parse(number, ref output);
            return output;
        }

        [TestCase(1001, Result = "one thousand and one")]
        [TestCase(1011, Result = "one thousand and eleven")]
        [TestCase(1020, Result = "one thousand and twenty")]
        [TestCase(1021, Result = "one thousand and twenty one")]
        [TestCase(1100, Result = "one thousand one hundred")]
        [TestCase(9999, Result = "nine thousand nine hundred and ninety nine")]
        public string ThousandsParser_UnitsPlusHundredsParser(int number)
        {
            string output = String.Empty;
            ThousandsParser parser = new ThousandsParser();
            parser.Parse(number, ref output);
            return output;
        }
    }
}

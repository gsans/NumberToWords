using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Unit
{
    [TestFixture]
    class MillionsParserTests
    {
        [TestCase(1000000, Result = "one million")]
        [TestCase(2000000, Result = "two million")]
        [TestCase(3000000, Result = "three million")]
        [TestCase(9000000, Result = "nine million")]
        public string MillionsParser_UnitsPlusMillions(int number)
        {
            string output = String.Empty;
            MillionsParser parser = new MillionsParser();
            parser.Parse(number, ref output);
            return output;
        }

        [TestCase(1000001, Result = "one million and one")]
        [TestCase(1000011, Result = "one million and eleven")]
        [TestCase(1000020, Result = "one million and twenty")]
        [TestCase(1000021, Result = "one million and twenty-one")]
        [TestCase(1000100, Result = "one million one hundred")]
        [TestCase(1001000, Result = "one million one thousand")]
        [TestCase(1010000, Result = "one million ten thousand")]
        [TestCase(1100000, Result = "one million one hundred thousand")]
        [TestCase(9999999, Result = "nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        public string MillionsParser_UnitsPlusThousandsParser(int number)
        {
            string output = String.Empty;
            MillionsParser parser = new MillionsParser();
            parser.Parse(number, ref output);
            return output;
        }

        [TestCase(99999999, Result = "ninety-nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(999999999, Result = "nine hundred and ninety-nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        public string MillionsParser_HundredsParserPlusThousandsParser(int number)
        {
            string output = String.Empty;
            MillionsParser parser = new MillionsParser();
            parser.Parse(number, ref output);
            return output;
        }
    }
}

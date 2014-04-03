using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Unit
{
    [TestFixture]
    class HundredParserTests
    {
        [TestCase(100, Result = "one hundred")]
        [TestCase(200, Result = "two hundred")]
        [TestCase(300, Result = "three hundred")]
        [TestCase(900, Result = "nine hundred")]
        public string HundredParser_UnitsPlusHundred(int number)
        {
            string output = String.Empty;
            HundredsParser parser = new HundredsParser();
            parser.Parse(number, ref output);
            return output;
        }

        [TestCase(101, Result = "one hundred and one")]
        [TestCase(201, Result = "two hundred and one")]
        [TestCase(301, Result = "three hundred and one")]
        [TestCase(901, Result = "nine hundred and one")]
        public string HundredParser_UnitsPlusAndUnitsHundred(int number)
        {
            string output = String.Empty;
            HundredsParser parser = new HundredsParser();
            parser.Parse(number, ref output);
            return output;
        }


        [TestCase(120, Result = "one hundred and twenty")]
        [TestCase(130, Result = "one hundred and thirty")]
        [TestCase(199, Result = "one hundred and ninety-nine")]
        public string HundredParser_UnitsPlusTensHundred(int number)
        {
            string output = String.Empty;
            HundredsParser parser = new HundredsParser();
            parser.Parse(number, ref output);
            return output;
        }

        [TestCase(121, Result = "one hundred and twenty-one")]
        [TestCase(131, Result = "one hundred and thirty-one")]
        [TestCase(999, Result = "nine hundred and ninety-nine")]

        public string HundredParser_UnitsPlusTensPlusUnitsHundred(int number)
        {
            string output = String.Empty;
            HundredsParser parser = new HundredsParser();
            parser.Parse(number, ref output);
            return output;
        }
    }
}

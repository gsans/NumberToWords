using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Unit
{
    [TestFixture]
    class UnitsParserTests
    {
        [TestCase(0, Result = "zero")]
        [TestCase(1, Result = "one")]
        [TestCase(2, Result = "two")]
        [TestCase(3, Result = "three")]
        [TestCase(4, Result = "four")]
        [TestCase(5, Result = "five")]
        [TestCase(6, Result = "six")]
        [TestCase(7, Result = "seven")]
        [TestCase(8, Result = "eight")]
        [TestCase(9, Result = "nine")]
        public string UnitsParser_ZeroToNine(int number)
        {
            string output = String.Empty;
            UnitsParser parser = new UnitsParser();
            parser.Parse(number, ref output);
            return output;
        }
    }
}

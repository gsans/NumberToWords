using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Integration
{
    [TestFixture]
    public class NumberToWords_Thousands_1000_999999
    {

        [TestCase(1000, Result = "one thousand")]
        [TestCase(1001, Result = "one thousand and one")]
        [TestCase(1010, Result = "one thousand and ten")]
        [TestCase(1019, Result = "one thousand and nineteen")]
        [TestCase(1020, Result = "one thousand and twenty")]
        [TestCase(1021, Result = "one thousand and twenty-one")]
        [TestCase(1099, Result = "one thousand and ninety-nine")]
        [TestCase(1199, Result = "one thousand one hundred and ninety-nine")]
        [TestCase(1999, Result = "one thousand nine hundred and ninety-nine")]
        [TestCase(9001, Result = "nine thousand and one")]
        [TestCase(9999, Result = "nine thousand nine hundred and ninety-nine")]
        [TestCase(90001, Result = "ninety thousand and one")]
        [TestCase(99999, Result = "ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(900001, Result = "nine hundred thousand and one")]
        [TestCase(999999, Result = "nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        public string NumberToWords_Thousands_1000_To_999999(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }
    }
}

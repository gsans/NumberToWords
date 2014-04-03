using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Integration
{
    [TestFixture]
    public class NumberToWords_Millions_1000000_999999999
    {

        [TestCase(1000000, Result = "one million")]
        [TestCase(1000001, Result = "one million and one")]
        [TestCase(1999999, Result = "one million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(9999999, Result = "nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(19999999, Result = "nineteen million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(99999999, Result = "ninety-nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(199999999, Result = "one hundred and ninety-nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        [TestCase(999999999, Result = "nine hundred and ninety-nine million nine hundred and ninety-nine thousand nine hundred and ninety-nine")]
        public string NumberToWords_Thousands_1000000_To_999999999(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }
    }
}

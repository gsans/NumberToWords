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
        [TestCase(1999999, Result = "one million nine hundred and ninety nine thousand nine hundred and ninety nine")]
        [TestCase(9999999, Result = "nine million nine hundred and ninety nine thousand nine hundred and ninety nine")]
        [TestCase(19999999, Result = "nineteen million nine hundred and ninety nine thousand nine hundred and ninety nine")]
        [TestCase(99999999, Result = "ninety nine million nine hundred and ninety nine thousand nine hundred and ninety nine")]
        [TestCase(199999999, Result = "one hundred and ninety nine million nine hundred and ninety nine thousand nine hundred and ninety nine")]
        [TestCase(999999999, Result = "nine hundred and ninety nine million nine hundred and ninety nine thousand nine hundred and ninety nine")]
        public string NumberToWords_Millions_1000000_To_999999999(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }

        [TestCase(Int32.MinValue, ExpectedException = typeof(ArgumentException))]
        [TestCase(-2147483647, Result = "minus two thousand one hundred and forty seven million four hundred and eighty three thousand six hundred and forty seven")]
        [TestCase(Int32.MaxValue, Result = "two thousand one hundred and forty seven million four hundred and eighty three thousand six hundred and forty seven")]
        public string NumberToWords_Millions_MinAndMaxValues(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }
    }
}

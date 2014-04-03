using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Integration
{
    [TestFixture]
    public class NumberToWords_Hundreds_100_999
    {

        [TestCase(100, Result = "one hundred")]
        [TestCase(101, Result = "one hundred and one")]
        [TestCase(110, Result = "one hundred and ten")]
        [TestCase(119, Result = "one hundred and nineteen")]
        [TestCase(120, Result = "one hundred and twenty")]
        [TestCase(121, Result = "one hundred and twenty one")]
        [TestCase(199, Result = "one hundred and ninety nine")]
        [TestCase(900, Result = "nine hundred")]
        [TestCase(901, Result = "nine hundred and one")]
        [TestCase(910, Result = "nine hundred and ten")]
        [TestCase(919, Result = "nine hundred and nineteen")]
        [TestCase(920, Result = "nine hundred and twenty")]
        [TestCase(921, Result = "nine hundred and twenty one")]
        [TestCase(999, Result = "nine hundred and ninety nine")]
        public string NumberToWords_Tens_TenToNineteen(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }
    }
}

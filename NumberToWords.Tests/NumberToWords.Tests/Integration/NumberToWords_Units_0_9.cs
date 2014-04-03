using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Integration
{
    [TestFixture]
    public class NumberToWords_Units_0_9
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
        public string NumberToWords_Units_ZeroToNine(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }
    }
}

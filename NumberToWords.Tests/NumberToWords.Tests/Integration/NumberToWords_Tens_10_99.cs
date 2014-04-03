using System;
using NUnit;
using NUnit.Framework;
using NumberToWords;

namespace NumberToWords.Tests.Integration
{
    [TestFixture]
    public class NumberToWords_Tens_10_99
    {

        [TestCase(10, Result = "ten")]
        [TestCase(11, Result = "eleven")]
        [TestCase(12, Result = "twelve")]
        [TestCase(13, Result = "thirteen")]
        [TestCase(14, Result = "fourteen")]
        [TestCase(15, Result = "fifteen")]
        [TestCase(16, Result = "sixteen")]
        [TestCase(17, Result = "seventeen")]
        [TestCase(18, Result = "eighteen")]
        [TestCase(19, Result = "nineteen")]
        public string NumberToWords_Tens_TenToNineteen(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }

        [TestCase(20, Result = "twenty")]
        [TestCase(30, Result = "thirty")]
        [TestCase(40, Result = "forty")]
        [TestCase(50, Result = "fifty")]
        [TestCase(60, Result = "sixty")]
        [TestCase(70, Result = "seventy")]
        [TestCase(80, Result = "eighty")]
        [TestCase(90, Result = "ninety")]
        public string NumberToWords_Tens_TwentyToNinety(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }

        [TestCase(21, Result = "twenty one")]
        [TestCase(22, Result = "twenty two")]
        [TestCase(23, Result = "twenty three")]
        [TestCase(24, Result = "twenty four")]
        [TestCase(25, Result = "twenty five")]
        [TestCase(26, Result = "twenty six")]
        [TestCase(27, Result = "twenty seven")]
        [TestCase(28, Result = "twenty eight")]
        [TestCase(29, Result = "twenty nine")]

        [TestCase(91, Result = "ninety one")]
        [TestCase(92, Result = "ninety two")]
        [TestCase(93, Result = "ninety three")]
        [TestCase(94, Result = "ninety four")]
        [TestCase(95, Result = "ninety five")]
        [TestCase(96, Result = "ninety six")]
        [TestCase(97, Result = "ninety seven")]
        [TestCase(98, Result = "ninety eight")]
        [TestCase(99, Result = "ninety nine")]
        public string NumberToWords_Tens_TwentyToNinetyNine(int number)
        {
            var library = new NumberToWords();
            return library.Read(number);
        }
    }
}

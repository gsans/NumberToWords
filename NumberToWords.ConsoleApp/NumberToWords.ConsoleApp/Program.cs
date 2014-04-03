using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string input = string.Empty;

            while (true)
            {
                Console.WriteLine("Enter a number to be converted to words [q:quit] : ");
                input = Console.ReadLine();
                if (input == "q") break;

                NumberToWords lib = new NumberToWords();
                if (Int32.TryParse(input, out number))
                    Console.WriteLine(lib.Read(number));
                else
                    Console.WriteLine("Input must be a number");                
            }
        }
    }
}

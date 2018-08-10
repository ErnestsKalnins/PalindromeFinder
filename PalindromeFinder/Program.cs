using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9999; i >= 1000; i--)
            {
                for (int j = 9999; j >= 1000; j--)
                {
                    if (IsPalindrome(i * j))
                    {
                        Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                        Console.ReadLine();
                    }
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            var numString = num.ToString();
            var charArray = numString.ToCharArray();
            Array.Reverse(charArray);
            return numString == new string(charArray);
        }
    }
}

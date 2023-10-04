using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class pallindrom
    {
        public static void Main(string[] args)
        {
            string s = "kanika";

            bool isPalindrome = IsPalindrome(s);

            if (isPalindrome)
            {
                Console.WriteLine($"{s} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{s} is not a palindrome.");
            }

            Console.ReadLine();


        }
        static bool IsPalindrome(string str)
        {
            // Convert the string to a character array
            char[] charArray = str.ToCharArray();

            int left = 0;
            int right = charArray.Length - 1;

            // Compare characters from the beginning and end of the array
            while (left < right)
            {
                if (charArray[left] != charArray[right])
                {
                    return false; // Not a palindrome
                }

                left++;
                right--;
            }

            return true; // It's a palindrome
        }
    }
}


using System;

namespace PalindromeNumber
{
    class Program
    {  
        static void Main(string[] args)
        {
            // Creat a function to determine given number is palindrome or not
            int num = 121;

            bool isPalindrome = isPalindrome(num);

            printPalindrome(isPalindrome);

            bool isPalidromeByString = IsPalidrome(num);

            PrintPalidrome(isPalindrome);
           
        }

        private static void PrintPalidrome(bool isPalindrome)

        private static bool IsPalidrome(int num)
        {
            int temp = num; // using temp so we can compare to the given number 
            int reverse = 0;
            int remainder; // take this and multiply by 10 on each interaction greater than one will reverse the number

            while (temp > 0)
            {
                remainder = temp % 10; // get extreme right number
                reverse reverse *10 + remainder; // extreme right number loop each time adding next right 
                temp = temp / 10; // divide by 10 to get rid of the digit

                // remainder = 1,     2,     1,
                // reverse   = 1,    12,   121,
                // temp      = 1     2     1

                return reverse == num;

            }

            private static bool IsPalidromeByString(int num)

        }

    }
}

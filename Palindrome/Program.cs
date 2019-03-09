using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            void palindrome(string input)
            {
                char[] array = input.ToCharArray();
                Array.Reverse(array);
                string reversed = new string(array);
                var result = input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

                if (result == true)
                {
                    Console.WriteLine($"{input} is a palindrome!");
                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome!");
                }
                //List<char> theInput = new List<char>();

                //foreach(char character in input)
                //{
                //    theInput.Add(character);
                //    Console.WriteLine(character);
                //}

                //Console.WriteLine("theInput: ", theInput);
            }

            Console.WriteLine($"Enter word to check if it's a palindrome: ");
            palindrome(Console.ReadLine());
            Console.ReadLine();
        }
    }
}

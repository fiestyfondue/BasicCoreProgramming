using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class VowelConsonent
    {
        public static void CheckVowel()
        {
            Console.WriteLine("Enter the character you want to check ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'e':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'i':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'o':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'u':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{alphabet} is a Consonent");
                    break;
            }

        }
    }
}

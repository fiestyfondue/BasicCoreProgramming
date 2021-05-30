using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class EvenOdd
    {
        public static void CheckOddEven()
        {
            Console.WriteLine("Enter the number you want to check for even or odd");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");

            }
        }
    }
}

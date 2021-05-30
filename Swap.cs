using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class Swap
    {
        public static void SwapNumber()
        {
            Console.WriteLine("Enter the two numbers to be swapped");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swap a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After Swap a = {a}, b ={b}");
        }
    }
}

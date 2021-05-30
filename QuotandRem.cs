using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class QuotandRem
    {
        public static void Divide()
        {
            Console.WriteLine("Enter the dividend and divisor respectively");
            int dividend;
            int divisor;
            int quotient, remainder;
            dividend = Convert.ToInt32(Console.ReadLine());
            divisor = Convert.ToInt32(Console.ReadLine());
            
            quotient = dividend % divisor;
            remainder = dividend / divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");


        }
    }
}

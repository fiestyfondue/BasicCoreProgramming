using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class Factors
    {
        public static void PrimeFactor()
        {
            Console.WriteLine("Enter the number for which PrimeFactorization will be performed");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            //number should be greater than 1.
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number /= 2;
            }

            for (int i = 3; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");

                    number /= i;
                }
            }

            if (number > 2)
            {
                Console.Write(number);
            }

        }
    }
}

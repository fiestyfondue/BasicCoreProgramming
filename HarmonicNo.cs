using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class GenerateHarmonicNo
    {
        public static int HarmonicNumber()
        {
            Console.WriteLine("Enter the value till where Harmonic number is desired:");
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            
            //variables
            float harmonic = 1;
            //check N != 0
            if (N <= 0)
            {
                Console.WriteLine($"Harmonic Number for {N} is: 0");
                return 0;
            }
            // generate Harmonic number for N

            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;

            }
            Console.WriteLine($"= {harmonic}");
            return 0;
        }
    }
}

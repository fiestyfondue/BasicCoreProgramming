using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{

    class FlipCoin
    {
        int tails = 0, heads = 0;
        const double DECISION = 0.5;
        public double PercentageCal(int coin, int numberofTurns)
        {

            double percentage;
            percentage = (coin * 100 / numberofTurns);
            return percentage;
        }
         
        public int PercentageFlips(int number)
        {

            int numberofTurns = number;                    // positive number check
            if (number <= 0)
            {
                return 0;
            }
            //variables
            int flips;
            double coinFace;
            double percentageTails, percentageHeads;
            Random random = new Random();                     //using random class to generate heads and tails


            for (flips = 1; flips <= numberofTurns; flips++)
            {
                coinFace = random.NextDouble();

                if (coinFace <= DECISION)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            percentageTails = PercentageCal(tails, numberofTurns);
            percentageHeads = PercentageCal(heads, numberofTurns);
            Console.WriteLine($"Percentage of heads: {percentageHeads}%");
            Console.WriteLine($"Percentage of tails: {percentageTails}%");
            

            return 0;
        }

    }
}

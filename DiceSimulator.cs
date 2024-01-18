using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceSimulator
    {
        //Creates a random object
        private static readonly Random random = new Random();

        //Roll simulation method
        public static int[] Simulate(int rolls)
        {
            //Sets the length of the array for results to 13
            int[] results = new int[13];

            //Sets the die to a specific number 1-6
            for (int i = 0; i < rolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);

                //Adds the value of the two die and saves that as the result
                results[die1 + die2]++;
            }

            //For each possible combination 2-12 save to results the percentage that combination was rolled
            for (int i = 2; i <= 12; i++)
            {
                results[i] = results[i] * 100 / rolls;
            }

            return results;
        }
    }
}

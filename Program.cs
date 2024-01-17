using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //declare rolls variable
        int rolls = 0;

        //Welcome user
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        //Prompt rolls to simulate
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        //Save the entered number to rolls
        rolls = int.Parse(System.Console.ReadLine());

        //Save results to an array from the simulate method in the dicesimulator class using rolls passed as a prameter
        int[] results = DiceSimulator.Simulate(rolls);

        //Show results
        System.Console.WriteLine("DICE SIMULATION RESULTS");

        System.Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");

        System.Console.WriteLine("Total number of rolls = " + rolls + "\n");

        //For each dice combo 2-12
        for (int i = 2; i <= 12; i++)
        {
            //Writes the output in a specific format i goes in the 0 position and 2 is the formatting
            System.Console.Write("{0,2}: ", i);

            //Put an astrix for each percent that roll was out of the total number of rolls
            for (int j = 0; j < results[i]; j++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine();
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

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
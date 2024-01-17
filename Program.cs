using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int rolls = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        rolls = int.Parse(System.Console.ReadLine());

        int[] results = DiceSimulator.Simulate(rolls);
        System.Console.WriteLine("DICE SIMULATION RESULTS");

        System.Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");

        System.Console.WriteLine("Total number of rolls = " + rolls + "\n");


        for (int i = 2; i <= 12; i++)
        {
            System.Console.Write("{0,2}: ", i);

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
    private static readonly Random random = new Random();

    public static int[] Simulate(int rolls)
    {
        int[] results = new int[13];

        for (int i = 0; i < rolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            results[die1 + die2]++;
        }

        for (int i = 2; i <= 12; i++)
        {
            results[i] = results[i] * 100 / rolls;
        }

        return results;
    }
}
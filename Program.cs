using System;
using Mission2;
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
using System;

//Ethan Nance program that rolls dice
class RollDice
{
    //Create the RollDicemethod that receives HowManyRolls as a parameter
    public static int[] RollDiceMethod(int HowManyRolls)
    {
        int die1 = 0;
        int die2 = 0;
        int total = 0;

        Random random = new Random();
        int[] rollTotals = new int[13];

        //For every time the user said to roll the dice, roll them and store the count of each total in the rollTotals array
        for (int iCount = 0; iCount < HowManyRolls; iCount++)
        {
            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);
            total = die1 + die2;

            rollTotals[total - 2]++;
        }

        //This is what the method is returning, this array
        return rollTotals;

    }
}

class Other
{
    //Create main class
    public static void Main(string[] args)
    {
        //Welcomes and gathers input from user
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
      
        int HowManyRolls = int.Parse(Console.ReadLine()); //Takes input from keyboard above
        int[] rollTotalsReceived = RollDice.RollDiceMethod(HowManyRolls); //This passes HowManyrolls into the RollDiceMethod, and stores the value that the method is returning (rollTotals) into a new varaible called rollTotalsReceived

        //Write other stuff
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {HowManyRolls}.");

        //Get percentage of how many times each total happened by accessing positions in array
        for (int iCount2 = 0; iCount2 < 11; iCount2++)
        {
            int percentage = (int)((double)rollTotalsReceived[iCount2] / HowManyRolls * 100);
            Console.Write((iCount2 + 2) + ": "); 

            //Print the same number of * as there was percentage ints in each position of array
            for (int iCount3 = 0; iCount3 < percentage; iCount3++)
            {
                Console.Write("*"); 
            }

            Console.WriteLine(); //Moves to new line
        }
        //bye bye
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
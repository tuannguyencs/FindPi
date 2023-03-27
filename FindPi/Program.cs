using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
namespace FindPi;

/*
    Created by tuannguyencs
    Problem -  Enter a number and have the program generate PI up to that many decimal places. Keep a limit to how far the program will go.
*/
public class Program
{
    static void Main(string[] args)
    {
        // Declaring as 0 to get the loop going
        int decimalPlaces = 0;

        // Math.PI only goes to 14 decimal places
        while (decimalPlaces < 1 || decimalPlaces > 14)
        {
            // User input
            Console.WriteLine("Please enter a number between 1 and 14 for desired decimal places of PI.");

            // Try catch statement in case of invalid input or number is more than 14
            try
            {
                decimalPlaces = Convert.ToInt32(Console.ReadLine());

                if (decimalPlaces > 14)
                {
                    Console.WriteLine("\nValue entered is more than 14, please try again.\n");
                    continue;
                }

                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Not a valid integer. Please try again.\n{ex.Message}\n");
            }
        }

        // Giving specific decimal values (could also use Round)
        string truncate = "#.";
        for (int i = 0; i < decimalPlaces; i++)
        {
            truncate += "#";
        }

        Console.WriteLine($"\nPI up to {decimalPlaces} decimal places: " + Math.PI.ToString(truncate));
    }
}
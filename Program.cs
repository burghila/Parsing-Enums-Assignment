using System;

namespace EnumParsingApp
{
    class Program
    {
        // Define an enum for the days of the week.
        enum DayOfWeek
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        static void Main(string[] args)
        {
            bool inputValid = false; // Used to check the validity of the input.

            while (!inputValid) // Continue to prompt until a valid input is given.
            {
                Console.WriteLine("Please enter the current day of the week:");

                try
                {
                    // Read user input from the console.
                    string input = Console.ReadLine();

                    // Parse the input to a DayOfWeek enum.
                    DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);

                    Console.WriteLine($"You entered: {today}");
                    inputValid = true; // Set to true when a valid input is parsed.
                }
                catch (Exception ex)
                {
                    // If parsing fails, catch the exception and prompt the user correctly.
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
        }
    }
}

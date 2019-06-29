using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2___Fun_Places_to_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgramAgain = true;

            while (runProgramAgain == true)
            {
                string transportation = "", activity = "", mood = "", userInput = "";
                int userInputAsInt = 0;
                bool repeat1 = true, repeat2 = true, repeat3 = true;

                while (repeat1 == true)
                {
                    Console.WriteLine("Hello user, what are you in the mood for?");
                    Console.WriteLine("Here are your options:");
                    Console.WriteLine("1) Action");
                    Console.WriteLine("2) Chilling");
                    Console.WriteLine("3) Danger");
                    Console.WriteLine("4) Good Food");

                    userInput = Console.ReadLine();
                    bool userInputSuccessfulyParsed = Int32.TryParse(userInput, out userInputAsInt);
                    if (userInputSuccessfulyParsed == true)
                    {
                        if (userInputAsInt == 1)
                        {
                            activity = "stock car racing";
                            mood = "action";
                            repeat1 = false;
                        }
                        else if (userInputAsInt == 2)
                        {
                            activity = "hiking";
                            mood = "chilling";
                            repeat1 = false;
                        }
                        else if (userInputAsInt == 3)
                        {
                            activity = "skydiving";
                            mood = "danger";
                            repeat1 = false;
                        }
                        else if (userInputAsInt == 4)
                        {
                            activity = "to Taco Bell";
                            mood = "good food";
                            repeat1 = false;
                        }
                        else
                        {
                            Console.WriteLine("User input not understood. Please try again.");
                            repeat1 = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("User input not understood. Please try again.");
                        repeat1 = true;
                    }
                }
                while (repeat2 == true)
                {
                    Console.WriteLine("How many people are coming with you?");

                    userInput = Console.ReadLine();
                    bool userInputSuccessfulyParsed = Int32.TryParse(userInput, out userInputAsInt);

                    if (userInputSuccessfulyParsed == true)
                    {
                        if (userInputAsInt == 0)
                        {
                            transportation = "sneakers";
                            repeat2 = false;
                        }
                        else if (userInputAsInt >= 1 && userInputAsInt <= 4)
                        {
                            transportation = "a sedan";
                            repeat2 = false;
                        }
                        else if (userInputAsInt >= 5 && userInputAsInt <= 10)
                        {
                            transportation = "a Volkswagen bus";
                            repeat2 = false;
                        }
                        else if (userInputAsInt >= 11)
                        {
                            transportation = "an airplane";
                            repeat2 = false;
                        }
                        else
                        {
                            Console.WriteLine("User input not understood. Please try again.");
                            repeat2 = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("User input not understood. Please try again.");
                        repeat2 = true;
                    }
                }
                Console.WriteLine("Okay, if you're in the mood for " + mood + ", then you should go " + activity + " and travel in " + transportation + ".");
                Console.WriteLine("Goodbye!");

                while (repeat3 == true)
                {
                    Console.WriteLine("Would you like to run this program again? Yes or no?");
                    userInput = Console.ReadLine();

                    if (userInput == "Yes" || userInput == "YES" || userInput == "yes")
                    {
                        runProgramAgain = true;
                        repeat3 = false;
                    }
                    else if (userInput == "No" || userInput == "NO" || userInput == "no")
                    {
                        runProgramAgain = false;
                        repeat3 = false;
                    }
                    else
                    {
                        Console.WriteLine("User input not understood. Please try again.");
                        repeat3 = true;
                    }
                }
            }

        }
    }
}

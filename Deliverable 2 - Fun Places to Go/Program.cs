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
                    if (userInput == "1")
                    {
                        activity = "stock car racing";
                        mood = "action";
                        repeat1 = false;
                    }
                    else if (userInput == "2")
                    {
                        activity = "hiking";
                        mood = "chilling";
                        repeat1 = false;
                    }
                    else if (userInput == "3")
                    {
                        activity = "skydiving";
                        mood = "danger";
                        repeat1 = false;
                    }
                    else if (userInput == "4")
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
                while (repeat2 == true)
                {
                    Console.WriteLine("How many people are coming with you?");
                    Console.WriteLine("1) 0");
                    Console.WriteLine("2) 1-4");
                    Console.WriteLine("3) 5-10");
                    Console.WriteLine("4) 11+");

                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        transportation = "sneakers";
                        repeat2 = false;
                    }
                    else if (userInput == "2")
                    {
                        transportation = "a sedan";
                        repeat2 = false;
                    }
                    else if (userInput == "3")
                    {
                        transportation = "a Volkswagen bus";
                        repeat2 = false;
                    }
                    else if (userInput == "4")
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

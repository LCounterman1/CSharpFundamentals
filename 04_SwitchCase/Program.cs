using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of the work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working.");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!!");
                    break;
            }

            //Challenge
            //Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response 
            //for each value. If they respond out of range, let them know. 

            Console.WriteLine("How are you feeling today?");
            string scale = Console.ReadLine();

            switch (scale)
            {
                case "1":
                    Console.WriteLine("What can we do to help?");
                    break;
                case "2":
                    Console.WriteLine("I'm sorry you are feeling like this");
                    break;
                case "3":
                    Console.WriteLine("Ok. How can we make it better?");
                    break;
                case "4":
                    Console.WriteLine("Good");
                    break;
                case "5":
                    Console.WriteLine("Glad to hear it!");
                    break;
                default:
                    Console.WriteLine("That is not an option. Please choose a number between 1-5");
                    break;
            }

            Console.ReadKey();

        }
    }
}

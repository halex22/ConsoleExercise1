using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise1
{
    internal class ExerciseTwo
    {
        public void MakeUserGuess()
        {
            int number = PickNumber();

            while (true)
            {
                string userInput = AskUserInput();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("please provide a number");
                    continue;
                }

                if (!int.TryParse(userInput, out int parsedInt))
                {
                    Console.WriteLine("Invalid input"); 
                    continue;
                }

                if (parsedInt == number)
                {
                    Console.WriteLine("Congratulation you have guessed the number");
                    break;
                }

                string message = $"Your guess is too {(parsedInt > number) switch
                {
                     true => " high",
                     false => "low",   

                }}";

                Console.WriteLine(message);

            }
        }

        public string AskUserInput()
        {
            Console.WriteLine("Please write a number between 0 and 10");
            string userInput = Console.ReadLine() ?? "";
            return userInput;
        }

        public int PickNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(11);
            return number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
namespace ConsoleExercise1
{
    internal class ExerciseThree(string main, string sub)
    {
        readonly string main = main;
        readonly string sub = sub;

        public int CountTimes()
        {
            int count = 0;
            string[] words = this.main.Split(' ');

            foreach (string word in words)
            {
                if (word.ToLower() == this.sub.ToLower()) count++;
            }
            return count;
        }
    }
}

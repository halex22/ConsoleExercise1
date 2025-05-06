using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercise1
{
    internal class ExerciseOne
    {
        public void ResolveExerciseOne()
        {
            int maxInt = 101;
            for (int i = 1; i < maxInt; i++)
            {
                if (Math.Sqrt(i) % 1 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("Papperone");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Pippo");
                } 
                else if (Math.Sqrt(i) % 1 == 0)
                {
                    Console.WriteLine("Pluto");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}

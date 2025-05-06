using ConsoleExercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        //int n = 1; // 32 bit
        //float f = 3.14f; // 32 bit   
        //double d = 3.14159; // 64 bit  
        //decimal m = 9.99m; // 128 bit
        //string str = "Hello World"; // 16 bit
        //string name = "John Doe"; // 16 bit
        //string interpol = $"Hello {name}"; // 16 bit
        //char c = 'A'; // 16 bit
        //bool b = true; // 1 bit
        //string verbatim = @"Hello World
        //                   it could be multiline"; // 16 bit ignores escape characters
        //var noType = 456;

        // todo's 
        // feez buzz log number 1-100 if divisible by 7 print pippo quadratto perfetto plutto, tutti due papperone
        //var exerciseOne = new ExerciseOne();
        //var exerciseTwo = new ExerciseTwo();
        //exerciseTwo.MakeUserGuess();
        //exerciseOne.ResolveExerciseOne();

        if (args.Length != 2)
        {
            Console.WriteLine("Two args are required");
            return;
        }

        string mainString = args[0];
        string subString = args[1];
        var three = new ExerciseThree(mainString, subString);
        int count = three.CountTimes();


        Console.WriteLine($"{subString} was found {count} times");

        //PrintHelloWorld();
        // read file and count target word
        // if only file gives feed statistic words, chars, vowels and consonants
        // translate cvs to json
    }

    private static void PrintHelloWorld()
    {
        Console.WriteLine("Hello World");
    }
}
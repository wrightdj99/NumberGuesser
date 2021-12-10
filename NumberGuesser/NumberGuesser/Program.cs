using System;

//Namespace
namespace NumberGuesser {

    //Main class
    public class Program
    {
       
        //Entry point method
        public static void Main(string[] args)
        {
            System.Random random = new System.Random();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Welcome to my number guessing game.");

            string appName = "Number Guesser";
            string version = "1.0.0";
            string appAuthor = "Dan Wright";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0}: VERSION: {1} by {2}", appName, version, appAuthor);
            //Change color back
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Let's go");
            //Start the game
            int correct = random.Next(0, 10);
            int guess = 0;
            int chances = 0;

            Console.WriteLine("Guess a number between 1 and 10");
            while (guess != correct) { 
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess)) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not an actual number!");
                    Console.ResetColor();
                    continue;
                }
                guess = Int32.Parse(input);
                if (guess != correct)
                {
                    chances++;
                    if (chances == 3)
                    {
                        Console.WriteLine("You ran out of chances, this is the correct number: {0}", correct);
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number!");
                        Console.ResetColor();
                    }
                }
                
            }
            //Output success message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Success!");
            Console.ResetColor();


        }
    }
}


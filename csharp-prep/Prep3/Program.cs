using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            Console.WriteLine("The computer has chosen a pseudo-random number!");
            Console.WriteLine($"Hint: it's {number}");
            Console.WriteLine("What is your best guess?");
            
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
            
            int numberOfGuesses = 1;
            
            while (guess != number)
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Some guess. Lower.");
                        numberOfGuesses++;
                        Console.WriteLine("What is your best guess?");
                        userInput = Console.ReadLine();
                        guess = int.Parse(userInput);
                    }
                    else
                    {
                        Console.WriteLine("Some guess. Higher.");
                        numberOfGuesses++;
                        Console.WriteLine("What is your best guess?");
                        userInput = Console.ReadLine();
                        guess = int.Parse(userInput);
                    }
                }
            
            Console.WriteLine($"You guessed it! It only took {numberOfGuesses} tries.");
            
            Console.WriteLine("Do you want to play again?");

            response = Console.ReadLine();
        }
    }
}
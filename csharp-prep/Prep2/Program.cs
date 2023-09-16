using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage.");
        string userInput = Console.ReadLine();

        int gradePercent = int.Parse(userInput);

        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent < 90 && gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent < 80 && gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent < 70 && gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string modifier = "";

        if ((gradePercent % 10) >= 7)
        {
            modifier = "+";
        }
        else if ((gradePercent % 10) < 3)
        {
            modifier = "-";
        }
        else
        {
            modifier = "";
        }

        if (letter == "F")
        {
            modifier = "";
        }

        if (letter == "A" && modifier == "+")
        {
            modifier = "";
        }

        if (gradePercent == 100)
        {
            modifier = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{modifier}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class. Better luck next time.");
        }
    }
}
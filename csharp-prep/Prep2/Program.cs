using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage.");
        string userInput = Console.ReadLine();

        int gpa = int.Parse(userInput);

        string letter = "";

        if (gpa >= 90)
        {
            letter = "A";
        }
        else if (gpa < 90 && gpa >= 80)
        {
            letter = "B";
        }
        else if (gpa < 80 && gpa >= 70)
        {
            letter = "C";
        }
        else if (gpa < 70 && gpa >= 60)
        {
            letter = "D";
        }
        else (gpa < 60)
        {
            letter = "F";
        }

        string modifier = "";

        if ((gpa % 10) >= 7)
        {
            modifier = "+";
        }
        else if ((gpa % 10) < 3)
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
            modifier == "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{modifier}");

        if (gpa >= 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the class. Better luck next time.");
        }
    }
}
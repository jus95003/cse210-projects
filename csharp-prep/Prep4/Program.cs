using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers (positive or negative), type 0 when finished.");
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        int newNumber = int.Parse(userInput);
        
        numbers.Add(newNumber);

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            newNumber = int.Parse(userInput);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is: {maximum}");

        int positiveMinimum = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0 && numbers[i] < positiveMinimum)
            {
                positiveMinimum = numbers[i];
            }
        }

        Console.WriteLine($"The smallest positive number is: {positiveMinimum}");

        numbers.Sort();

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}
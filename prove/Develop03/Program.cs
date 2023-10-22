using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Please enter a book of scripture reference (e.g., 'Genesis' or '1 Nephi' or 'Doctrine and Covenants').");
        Console.WriteLine();
        Console.WriteLine("Do not use hyphens or dashes for 'Joseph Smith Matthew' or 'Joseph Smith History'.");
        Console.WriteLine();

        string book = Console.ReadLine();

        while (book.Contains('-') || book.Contains(':'))
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a book of scripture reference (e.g., 'Genesis' or '1 Nephi' or 'Doctrine and Covenants').");
            Console.WriteLine();
            Console.WriteLine("Do not use hyphens or dashes for 'Joseph Smith Matthew' or 'Joseph Smith History'.");
            Console.WriteLine();

            book = Console.ReadLine();
        }

        int chapterValidate = 0;

        while (chapterValidate < 1)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the chapter of the scripture reference.");
            Console.WriteLine();

            string chapterChoice = Console.ReadLine();

            foreach (Char character in chapterChoice)
            {
                if (!Char.IsNumber(character))
                {
                    chapterValidate = 0;
                }

                else
                {
                    chapterValidate = Int32.Parse(chapterChoice);
                }
            }
        }

        int firstVerseValidate = 0;

        while (firstVerseValidate < 1)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the verse of the scripture reference. If this is a block of scriptures, enter the first verse.");
            Console.WriteLine();

            string firstVerseChoice = Console.ReadLine();

            foreach (Char character in firstVerseChoice)
            {
                if (!Char.IsNumber(character))
                {
                    firstVerseValidate = 0;
                }

                else
                {
                    firstVerseValidate = Int32.Parse(firstVerseChoice);
                }
            }
        }

        int secondVerseValidate = 0;

        while (secondVerseValidate < 1)
        {
            Console.WriteLine();
            Console.WriteLine("If this is a block of scriptures, enter the second verse. Otherwise, re-enter the verse if it is a single verse.");
            Console.WriteLine();

            string secondVerseChoice = Console.ReadLine();

            foreach (Char character in secondVerseChoice)
            {
                if (!Char.IsNumber(character))
                {
                    secondVerseValidate = 0;
                }

                else
                {
                    secondVerseValidate = Int32.Parse(secondVerseChoice);
                }
            }
        }

        string reference = "";

        if (secondVerseValidate < firstVerseValidate)
        {
            Console.WriteLine();
            Console.WriteLine("The second verse cannot be lower than the first verse.");
            Console.WriteLine();
            Console.WriteLine("Please try again later.");
            Console.WriteLine();

            return;
        }

        else if (secondVerseValidate == firstVerseValidate)
        {
            reference = book + " " + chapterValidate.ToString() + ":" + firstVerseValidate.ToString();
        }

        else
        {
            reference = book + " " + chapterValidate.ToString() + ":" + firstVerseValidate.ToString() + "-" + secondVerseValidate.ToString();
        }

        Scripture scripture = new Scripture(reference);

        if (scripture.GetText() == "Scripture not found.")
        {
            Console.WriteLine();
            Console.WriteLine($"{scripture.GetReference()} - {scripture.GetText()}");
            Console.WriteLine();

            return;
        }

        int difficulty = 0;

        while (difficulty < 1 || difficulty > 4)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a difficulty level:");
            Console.WriteLine();
            Console.WriteLine("'1' for Easy");
            Console.WriteLine("'2' for Moderate");
            Console.WriteLine("'3' for Hard");
            Console.WriteLine("'4' for Show-off");
            Console.WriteLine();

            string diffChoice = Console.ReadLine();

            char diffChoiceChar = diffChoice[0];

            if (!Char.IsNumber(diffChoiceChar))
            {
                difficulty = 0;
            }

            else
            {
                difficulty = Int32.Parse(diffChoice);
            }
        }

        scripture.SetDifficulty(difficulty);

        Console.Clear();

        Console.WriteLine($"{scripture.GetReference()} - {scripture.GetText()}");

        Console.WriteLine();

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        Console.WriteLine();

        string proceedOrQuit = Console.ReadLine();

        while (proceedOrQuit != "quit" && scripture.AreAllWordsModified() == 0)
        {
            if (scripture.AreAllWordsModified() == 0)
            {
                scripture.DisplayScriptures();

                Console.WriteLine();

                Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                Console.WriteLine();

                proceedOrQuit = Console.ReadLine();
            }

            else
            {
                return;
            }
        }

        return;
    }
}
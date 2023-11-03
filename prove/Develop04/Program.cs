using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();

            choice = 0;

            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Select a choice from the menu:  ");
                
                string menuChoice = Console.ReadLine();

                Console.WriteLine();

                char menuChoiceChar = menuChoice[0];

                if (!Char.IsNumber(menuChoiceChar))
                {
                    choice = 0;
                }

                else
                {
                    choice = Int32.Parse(menuChoice);
                }
            }

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.RunBreathingActivity();
            }

            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();

                reflectingActivity.RunReflectingActivity();
            }

            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();

                listingActivity.RunListingActivity();
            }

            else
            {
                return;
            }
        } while(choice != 4);
    }
}
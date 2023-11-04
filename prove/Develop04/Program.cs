using System;
using System.ComponentModel.Design;

class Program
{
    // My effort to to show creativity and exceed the requirements was to add an additional mindfulness activity - the Centering Activity.
    // It is set up the same way as the other activities. The user sees the activity name and description, and they are asked to input a
    // duration for the activity. The activity then displays various ASCII art of the Savior for the user to focus on. I chose not to make
    // the art selection random because I want the user to see as many pieces as possible during the activity. 

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();

            choice = 0;

            while (choice < 1 || choice > 5)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine();
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Start centering activity");
                Console.WriteLine("5. Quit");
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

            else if (choice == 4)
            {
                CenteringActivity centeringActivity = new CenteringActivity();

                centeringActivity.RunCenteringActivity();
            }

            else
            {
                return;
            }
        } while(choice != 5);
    }
}
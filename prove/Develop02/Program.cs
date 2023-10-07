using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();

        bool _displayMenu = true;

        while (_displayMenu == true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string _choice = Console.ReadLine();

            if (_choice == "1" || _choice == "Write" || _choice == "write")
            {
                _journal.WriteEntry();
            }

            else if (_choice == "2" || _choice == "Display" || _choice == "display")
            {
                _journal.DisplayJournal();
            }

            else if (_choice == "3" || _choice == "Load" || _choice == "load")
            {
                Console.WriteLine("What is the filename?");
                string _loadFileName = Console.ReadLine();
                _journal.LoadJournal(_loadFileName);
            }

            else if (_choice == "4" || _choice == "Save" || _choice == "save")
            {
                Console.WriteLine("If you want to save to an existing JSON file,");
                Console.WriteLine("load the existing JSON first or it will be overwritten.");
                Console.WriteLine();
                Console.WriteLine("Proceed with saving? (yes/no)");

                string _decision = Console.ReadLine();

                if (_decision == "yes")
                {
                    Console.WriteLine("What is the filename?");
                    string _saveFileName = Console.ReadLine();
                    _journal.SaveJournal(_saveFileName);
                }
            }

            else
            {
                _displayMenu = false;
            }
        }
    }
}
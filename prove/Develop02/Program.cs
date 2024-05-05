using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        bool quit = false;

        while (!quit)
        {

            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                journal.AddEntry();
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == "4")
            {
                Console.WriteLine("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "5")
            {
                quit = true;
            }
        }

    }
}

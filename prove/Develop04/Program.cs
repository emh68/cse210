using System;
using System.Threading;
using System.IO;
using System.Speech.Synthesis;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"Welcome to the mindfulness program!");
        Console.WriteLine();

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity ");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please choose one of the following menu options: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking you through a breathing exercise.\nYou will first breathe in, then you will hold that breath, then you will exhale through your mouth.\nClear your mind and focus on your breathing.", 0);
                breathing.Run();
            }

            else if (choice == "2")
            {
                Reflecting reflecting = new Reflecting("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflecting.Run();
            }

            else if (choice == "3")
            {
                Listing listing = new Listing(0, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can for the duration of the time.\nYou will be given a prompt to help guide you, but feel free to use your own if you choose to.", 0);
                listing.Run();
            }

            else if (choice == "4")
            {
                quit = true;
            }

            else
            {
                Console.WriteLine("Invalid option. Please enter the number from the menu corresponding to your choice.");
            }
        }
    }
}
// Activity activity = new Activity("Breathing", "A simple breathing exercise", 30);
// activity.DisplayStartingMessage(activity.GetType().Name);
// activity.ShowCountDown(30);
// activity.DisplayEndingMessage();
// SpeechSynthesizer synth = new SpeechSynthesizer();
// synth.SetOutputToDefaultAudioDevice();
// synth.Speak("Hello Develop04 World!");

// synth.Rate = -1;

// synth.Speak("Take a deep breath in.");

// Thread.Sleep(5000);

// synth.Speak("Now slowly breathe out.");


// for (int i = 30; i > 0; i--)
// {
//     Console.Write(i);
//     Thread.Sleep(1000);
//     Console.Write("\b \b\b \b");
// }

// Console.WriteLine("Done.");


using System;
using System.Threading;
using System.IO;
using System.Speech.Synthesis;


class Program
{
    static void Main(string[] args)
    {

        Activity activity = new Activity();
        Console.WriteLine($"Welcome to the mindfulness program!");

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
                Breathing.Run();
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
    }

}



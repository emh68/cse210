// using System;
// using System.Collections.Generic;
// using System.Speech.Synthesis;

// public class Listing : Activity
// {
//     private int _count;
//     private List<string> _prompts;


//     public Listing(int count, string name, string description, int duration) : base(name, description, duration)
//     {
//         _count = count;
//         _prompts = new List<string>()
//         {
//             "Who are people that you appreciate?",
//             "What are personal strengths of yours?",
//             "Who are people that you have helped this week?",
//             "When have you felt the Holy Ghost this month?",
//             "Who are some of your personal heroes?"
//         };
//     }

//     public void Run()
//     {
//         DisplayStartingMessage();
//         Console.WriteLine("How long, in seconds, would you like for your session?");
//         int duration = int.Parse(Console.ReadLine());

//         GetRandomPrompt();

//         GetListFromUser();
//     }

//     public void GetRandomPrompt()
//     {
//         Random random = new Random();
//         int indexVal = random.Next(_prompts.Count);
//         Console.WriteLine($"List as many responses as you can to the following prompt\n*** {_prompts[indexVal]} ***");
//         Console.WriteLine();
//         Console.Write("You may begin in: ");
//         ShowCountDown(5);
//         Console.WriteLine();
//     }


//     public List<string> GetListFromUser(int duration)
//     {
//         List<string> userResponses = new List<string>();
//         Console.WriteLine("Press enter after each response is complete.");
//         string response;
//         while(duration > 0)
//         {
//             response = Console.ReadLine().Trim();
//             if (!string.IsNullOrWhiteSpace(response))
//             {
//                 userResponses.Add(response);
//             }
//         } while (!string.IsNullOrWhiteSpace(response));

//         for (int i = 0; i < userResponses.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {userResponses[i]}");
//         }
//     }
// }
// using System;
// using System.Collections.Generic;
// using System.Threading;

// public class Listing : Activity
// {
//     private List<string> _prompts;

//     public Listing(int count, string name, string description, int duration) : base(name, description, duration)
//     {
//         _prompts = new List<string>()
//         {
//             "Who are people that you appreciate?",
//             "What are personal strengths of yours?",
//             "Who are people that you have helped this week?",
//             "When have you felt the Holy Ghost this month?",
//             "Who are some of your personal heroes?"
//         };
//     }

//     public void Run()
//     {
//         DisplayStartingMessage();
//         Console.WriteLine("How long, in seconds, would you like for your session?");
//         int duration = int.Parse(Console.ReadLine());

//         GetRandomPrompt();
//         List<string> userResponses = GetListFromUser(duration);

//         DisplayEndingMessage();
//         DisplayResponses(userResponses);
//     }

//     public void GetRandomPrompt()
//     {
//         Random random = new Random();
//         int indexVal = random.Next(_prompts.Count);
//         Console.WriteLine($"List as many responses as you can to the following prompt\n*** {_prompts[indexVal]} ***");
//         Console.WriteLine();
//         Console.Write("You may begin in: ");
//         ShowCountDown(5);
//         Console.WriteLine();
//     }

//     public List<string> GetListFromUser(int duration)
//     {
//         List<string> userResponses = new List<string>();
//         Console.WriteLine("Press enter after each response is complete.");
//         string response;

//         DateTime startTime = DateTime.Now;
//         TimeSpan remainingTime = TimeSpan.FromSeconds(duration);

//         while (remainingTime.TotalSeconds > 0)
//         {
//             remainingTime = TimeSpan.FromSeconds(duration) - (DateTime.Now - startTime);
//             if (remainingTime.TotalSeconds <= 0)
//             {
//                 break;
//             }

//             // Console.CursorLeft = 0;
//             // Console.WriteLine($"Time remaining: {remainingTime:mm\\:ss}");

//             response = Console.ReadLine().Trim();
//             if (!string.IsNullOrWhiteSpace(response))
//             {
//                 userResponses.Add(response);
//             }
//         }


//         return userResponses;
//     }

//     public void DisplayResponses(List<string> responses)
//     {
//         Console.WriteLine("Your responses:");
//         for (int i = 0; i < responses.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {responses[i]}");
//         }
//     }
// }
using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private List<string> _prompts;

    public Listing(int count, string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        GetRandomPrompt();
        List<string> userResponses = GetListFromUser(duration);

        DisplayEndingMessage();
        DisplayResponses(userResponses);
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int indexVal = random.Next(_prompts.Count);
        Console.WriteLine($"List as many responses as you can to the following prompt\n*** {_prompts[indexVal]} ***");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> userResponses = new List<string>();
        Console.WriteLine("Press enter after each response is complete.");
        string response;

        DateTime startTime = DateTime.Now;
        TimeSpan remainingTime;

        do
        {
            remainingTime = TimeSpan.FromSeconds(duration) - (DateTime.Now - startTime);

            if (Console.KeyAvailable)
            {
                response = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    userResponses.Add(response);
                }
            }
        } while (remainingTime.TotalSeconds > 0);

        return userResponses;
    }

    public void DisplayResponses(List<string> responses)
    {
        Console.WriteLine("Your responses:");
        for (int i = 0; i < responses.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {responses[i]}");
        }
    }
}

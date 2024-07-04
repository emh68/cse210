public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public Reflecting(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of the last time you did something really fun or exciting.",
            "Think of the last time you were really really happy.",
            "Think of a time when you felt like you made a difference in the world.",
            "Think of a time when you did something out of your comfort zone."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        GetRandomPrompt();

        List<int> usedIndices = new List<int>();
        int elapsedSeconds = 0;
        Random random = new Random();

        while (elapsedSeconds < duration && usedIndices.Count < _questions.Count)
        {
            int questionPause = 10;
            GetUniqueRandomQuestion(random, usedIndices);
            ShowSpinner(questionPause);
            elapsedSeconds += questionPause;
        }

        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int indexVal = random.Next(_prompts.Count);
        Console.WriteLine($"*** {_prompts[indexVal]} ***");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(10);
        Console.WriteLine();
    }

    public void GetUniqueRandomQuestion(Random random, List<int> usedIndices)
    {
        int indexVal;
        do
        {
            indexVal = random.Next(_questions.Count);
        } while (usedIndices.Contains(indexVal));

        usedIndices.Add(indexVal);
        Console.WriteLine(_questions[indexVal]);
    }
}
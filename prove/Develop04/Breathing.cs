public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        var breathingCycle = new (string Message, int Duration)[]
        {
            ("Breathe in...", 5),
            ("Hold your breath...", 4),
            ("Now exhale through your mouth...", 6)
        };

        while (duration > 0)
        {
            foreach (var stage in breathingCycle)
            {
                if (duration <= 0) break;

                Console.Write($"{stage.Message}");
                ShowCountDown(stage.Duration);
                Console.WriteLine();
                duration -= stage.Duration;

            }
        }

        DisplayEndingMessage();
    }
}

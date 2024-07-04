public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready...");
        ShowSpinner(10);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("The activity has ended. Well done!");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>()
        {
            "|", "/", "-", "\\"
        };

        int animationLength = animation.Count;
        int i = 0;

        while (i < seconds)

        {
            string s = animation[i % animationLength];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
        }

        if (i >= animation.Count)
        {
            i = 0;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i.ToString().PadLeft(2));
            Thread.Sleep(1000);

            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);

            Console.Write("  ");

            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
    }
}
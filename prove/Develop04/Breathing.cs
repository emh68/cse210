public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int remaingingTime = _duration;

        while (remaingingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(seconds);
            remaingingTime -= seconds;

            if (remaingingTime <= 0)
            {
                break;
            }

            Console.WriteLine("Breathe out...");
            ShowCountDown(seconds);
            remaingingTime -= seconds;
        }

        DisplayEndingMessage();
    }
}
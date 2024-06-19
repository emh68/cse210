
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

    public void DisplayStartingMessage(string name)
    {
        string startingMessage = $"Welcome to the {name} activity!";
    }

    public void DisplayEndingMessage()
    {
        string endingMessage = "The activity has ended. Well done!";
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b\b \b");
        }
    }
}
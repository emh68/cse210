using System.Speech.Synthesis;
public class Breathing : Activity
{
    private SpeechSynthesizer _synth;
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
        _synth = new SpeechSynthesizer();
        _synth.SetOutputToDefaultAudioDevice();
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

                _synth.Speak(stage.Message);
                Console.Write($"{stage.Message}");
                ShowCountDown(stage.Duration);
                Console.WriteLine();
                duration -= stage.Duration;
            }
        }
        DisplayEndingMessage();
    }

    public override void DisplayEndingMessage()
    {
        Console.WriteLine("The breathing session has ended. Well done!");
        _synth.Speak("The breathing session has ended. Well done!");
    }
}

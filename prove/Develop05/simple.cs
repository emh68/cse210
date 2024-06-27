public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool IsComplete) : base(name, description, points)
    {
        _isComplete = IsComplete;
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {

    }

    public string GetStringRepresentation()
    {

    }
}
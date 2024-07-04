public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    protected GoalManager _goalManager;

    public Goal(string shortName, string description, int points, GoalManager goalManager)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _goalManager = goalManager;
    }

    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string shortName)
    {
        _shortName = shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetSavedString();
    public abstract string GetStringRepresentation();
}
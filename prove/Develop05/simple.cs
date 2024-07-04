public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete, GoalManager goalManager) : base(name, description, points, goalManager)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        _goalManager.IncreaseScore(GetPoints());
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetSavedString()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
    public override string GetStringRepresentation()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} - {GetDescription()} - {GetPoints()} points";
    }
}
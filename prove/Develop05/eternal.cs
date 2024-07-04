public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, GoalManager goalManager) : base(name, description, points, goalManager)
    {

    }

    public override void RecordEvent()
    {
        _goalManager.IncreaseScore(GetPoints());
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetSavedString()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {GetName()} - {GetDescription()} - {GetPoints()} points (Eternal)";
    }
}
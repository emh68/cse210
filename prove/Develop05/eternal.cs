public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, GoalManager goalManager) : base(name, description, points, goalManager)
    {

    }

    public override void RecordEvent()
    {
        GoalManager goalManager = new GoalManager();
        goalManager.IncreaseScore(GetPoints());
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {GetName()}: {GetDescription()} - {GetPoints()} points (Eternal)";
    }
}
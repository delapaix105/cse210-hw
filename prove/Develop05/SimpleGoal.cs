public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {(IsComplete ? "[X]" : "[ ]")}";
    }
}

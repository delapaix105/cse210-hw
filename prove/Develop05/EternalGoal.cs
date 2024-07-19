public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points)
    {
    }

    public override void RecordEvent()
    {
        Points += 100; // Example value
    }

    public override string GetDetailsString()
    {
        return $"{Name} - [Eternal] {Points} points";
    }
}

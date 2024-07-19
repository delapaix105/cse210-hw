public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            IsComplete = true;
            Points += bonusPoints;
        }
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {currentCount}/{targetCount} {(IsComplete ? "[X]" : "[ ]")}";
    }
}

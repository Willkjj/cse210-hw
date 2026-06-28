class EternalGoal : BaseGoal
{
    public EternalGoal() : base()
    {
        
    }

    public EternalGoal(string goalName, string goalDescription, double pointValue, bool isComplete, double timesCompleted, string goalType) : base(goalName, goalDescription, pointValue, isComplete, timesCompleted, goalType)
    {
        
    }
    public override string GetDisplayString()
    {
        
        return $"{base.GetDisplayString()}, times completed: {getTimesCompelted()}";

    }
    protected override void CompleteTask()
    {
    }
    public override void CreateGoal()
    {
        SetGoalType("EternalGoal");
        SetGoalName();
        SetGoalDescription();
        SetPointValue();
    }
    public override double RecordEvent()
    {
        CompleteTask();
        CompleteTaskDouble();
        Console.WriteLine("Goal Recorded!");
        return GetPointValue();

    }
}
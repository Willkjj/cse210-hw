class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {
        
    }

    public SimpleGoal(string goalName, string goalDescription, double pointValue, bool isComplete, double timesCompleted, string goalType) : base(goalName, goalDescription, pointValue, isComplete, timesCompleted, goalType)
    {
        
    }
    protected override void CompleteTask()
    {
        MarkComplete();
    }
    public override void CreateGoal()
    {
        SetGoalType("SimpleGoal");
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
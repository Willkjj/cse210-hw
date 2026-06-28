using System.Data;
using System.Threading.Channels;

class ChecklistGoal : BaseGoal
{
    double _bonusPoints;
    double _bonusPointsRequirement;

    public ChecklistGoal()
    {
        
    }
    public ChecklistGoal(string goalName, string goalDescription, double pointValue, bool isComplete, double timesCompleted, string goalType, double bonusPoints, double bonusPointsRequirement) : base(goalName, goalDescription, pointValue, isComplete, timesCompleted, goalType)
    {
        _bonusPoints = bonusPoints;
        _bonusPointsRequirement = bonusPointsRequirement;
        
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()}#{_bonusPoints}#{_bonusPointsRequirement}";
    }
    public override string GetDisplayString()
    {
        
        return $"{base.GetDisplayString()}, times completed: {getTimesCompelted()}/{_bonusPointsRequirement}";

    }
    protected override void CompleteTask()
    {
        
        if (getTimesCompelted() >= _bonusPointsRequirement)
        {
            MarkComplete();
        } 
    }
    public override double RecordEvent()
    {
        CompleteTaskDouble();
        CompleteTask();
        Console.WriteLine("Goal Recorded!");
        if (CheckCompleted())
        {
            return GetPointValue() + _bonusPoints;

        } else
        {
            return GetPointValue();

        }
    }
    public override void CreateGoal()
    {
        SetGoalType("ChecklistGoal");
        SetGoalName();
        SetGoalDescription();
        SetPointValue();
        SetRequirements();
        SetBonusPoints();
    }

    private void SetRequirements()
    {
        Console.WriteLine("How many times do you need to accomplish this goal to receive the bonus? ");
        _bonusPointsRequirement = double.Parse(Console.ReadLine());
    }
    private void SetBonusPoints()
    {
        Console.WriteLine("How many bonus points do you get for accomplishing it that many times? ");
        _bonusPoints = double.Parse(Console.ReadLine());
    }
}
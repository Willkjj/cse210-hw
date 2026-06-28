abstract class BaseGoal
{
    private string _goalName;

    private string _goalDescription;

    private double _pointValue;
    private bool _isComplete;

    private double _timesCompleted;
    private string _goalType;

    public BaseGoal()
    {
        _goalName = "";
        _goalDescription = "";
        _pointValue = 0;
        _isComplete = false;
        _timesCompleted = 0;
        _goalType = "";
        
    }

    public BaseGoal(string goalName, string goalDescription, double pointValue, bool isComplete, double timesCompleted, string goalType)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointValue = pointValue;
        _isComplete = isComplete;
        _timesCompleted = timesCompleted;
        _goalType = goalType;

    }

    public bool CheckCompleted()
    {
        return _isComplete;
    }

    public abstract void CreateGoal();
    public abstract double RecordEvent();
    protected abstract void CompleteTask();

    // protected abstract void GivePoints();
    

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}#{_isComplete}#{_goalName}#{_goalName}#{_pointValue}#{_timesCompleted}";
    }

    protected void SetGoalType(string goaltype)
    {
        _goalType = goaltype;
    }
    protected void SetGoalName()
    {
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
    }
    protected void SetGoalDescription()
    {
        Console.WriteLine("What is your goal?");
        _goalDescription = Console.ReadLine();
    }

    protected double GetPointValue()
    {
        return _pointValue;
    }
    protected void SetPointValue()
    {
        bool succeeded = false;

        Console.WriteLine("How many points should you get for completing this goal?");
        while (!succeeded)
        {
            succeeded = true;
            try
            {
                _pointValue = int.Parse(Console.ReadLine());
                
            }
            catch 
            {
                succeeded = false;
                Console.WriteLine("Please enter in a numeric value!");
            } 
        }

    }
    public virtual string GetDisplayString()
    {
        char statusMarker = ' ';
        if (_isComplete)
        {
            statusMarker = 'X';
        }
        
        return $"[{statusMarker}] Name: {_goalName}, Description: {_goalDescription}, points: {_pointValue}";

    }

    protected void MarkComplete()
    {
        _isComplete = true;
    }
    protected void CompleteTaskDouble()
    {
        _timesCompleted++;
    }
    protected double getTimesCompelted()
    {
        return _timesCompleted;
    }
}
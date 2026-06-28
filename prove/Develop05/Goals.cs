using System.ComponentModel.DataAnnotations;

class Goals
{
    private List<BaseGoal> goals = new List<BaseGoal>();
    private string _fileSystemString;
    private double _totalPoints;

    public Goals()
    {
    }
    public void AddGoal(BaseGoal goal)
    {
        goals.Add(goal);
    }
    public void DisplayTotalPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }
    public double GetPoints()
    {
        return _totalPoints;
    }

    public void ListGoals()
    {
        int i = 0;
        Console.Clear();
        foreach (BaseGoal goal in goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDisplayString()}");

        }
        DisplayTotalPoints();
    }
    public void RewardPoints(double points)
    {
        _totalPoints += points;
    }
    public void RecordEvent()
    {
        if (goals.Count <= 0)
        {
            Console.WriteLine("You have no goals to complete.");

        } else
        {
            Console.WriteLine();
            Console.Write("Which goal did you work on? ");

            bool succeeded = false;
            while (!succeeded)
            {
                succeeded = true;
                try
                {
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;

                    if (goals[goalIndex].CheckCompleted())
                    {
                        Console.WriteLine("You already completed that goal.");
                    }
                    else
                    {
                        RewardPoints(goals[goalIndex].RecordEvent());

                    }
                }

                catch
                {
                    Console.WriteLine("Please enter a valid option.");
                    succeeded = false;
                }
            }
              
        }

    }

    private void SetFileSystemString()
    {
        Console.WriteLine("What file would you like to save your goals to?");
        _fileSystemString = Console.ReadLine();
    }

    public void ReadFromFile()
    {
        bool fileFound = false;
        
        while (!fileFound)
        {
            try
            {
                Console.WriteLine("What is the filename? ");
                string filename = "./" + $"{Console.ReadLine()}";

                string[] lines = System.IO.File.ReadAllLines(filename);

                double i = 0;

                foreach (string line in lines)
                {
                    string[] fileEntries = line.Split("##");

                    foreach (string fileEntry in fileEntries)
                    {
                        i++;
                        
                        string[] parts = line.Split("#");

                        if(i == 1)
                        {
                            _totalPoints = double.Parse(parts[0]);
                            break;
                        }

                        if (parts[0] == "SimpleGoal")
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(parts[2], parts[3], double.Parse(parts[4]), bool.Parse(parts[1]),double.Parse(parts[5]), parts[0]);
                            AddGoal(simpleGoal);
                            break;
                        } else if (parts[0] == "ChecklistGoal")
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[2], parts[3], double.Parse(parts[4]), bool.Parse(parts[1]),double.Parse(parts[5]), parts[0], double.Parse(parts[6]),double.Parse(parts[7]));
                            AddGoal(checklistGoal);
                            break;
                        }  else if (parts[0] == "EternalGoal")
                        {
                            EternalGoal eternalGoal = new EternalGoal(parts[2], parts[3], double.Parse(parts[4]), bool.Parse(parts[1]),double.Parse(parts[5]), parts[0]);
                            AddGoal(eternalGoal);
                            break;
                        } 
                    }

                }

                fileFound = true;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                fileFound = false;
            } 
        }

        Console.WriteLine();
        Console.WriteLine("File loaded.");

    }
   

    public void SaveToFile()
    {
        SetFileSystemString();
        try
        {
            File.Delete("./" + _fileSystemString);
    
        }
        catch
        {
        }

        using (StreamWriter outputFile = new StreamWriter(_fileSystemString, append: true))
        {
            outputFile.WriteLine($"{_totalPoints}##");

        }

        foreach (BaseGoal goal in goals)
        {
            
            using (StreamWriter outputFile = new StreamWriter(_fileSystemString, append: true))
            {
                outputFile.WriteLine($"{goal.GetFileSystemString()}##");

            }
        }
        
        Console.WriteLine($"File saved as {_fileSystemString}");
    }

    public void Continue()
    {
        Console.WriteLine();
        Console.Write("Press Enter to Continue.");
        Console.ReadLine();
    }
}
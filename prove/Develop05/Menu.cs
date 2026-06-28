using System.Reflection.Metadata;

class Menu
{
    int _userInput;

    Goals goals = new Goals();


    public void DisplayMenu()
    {

        _userInput = 0;
        while (_userInput !=7)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Shop");
            Console.WriteLine("    7. Quit");

            Console.Write("Select a choice from the menu: ");

            try
            {
                _userInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please choose one of the options!");
            }

            switch (_userInput)
            {
                case 1: 
                    DisplayCreateGoalMenu();
                    break;

                case 2: 
                    goals.ListGoals();
                    goals.Continue();
                    break;

                case 3: 
                    goals.SaveToFile();
                    goals.Continue();
                    break;

                case 4: 
                    goals.ReadFromFile();
                    goals.Continue();
                    break;

                case 5: 
                    goals.ListGoals();
                    goals.RecordEvent();
                    goals.Continue();
                    break;

                case 6:
                    DisplayShopMenu();
                    break;

                case 7:
                    break;
            }

        }
    }

    private void DisplayCreateGoalMenu()
    {
        int _userInput = 0;
        while (_userInput !=4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Create Simple Goal");
            Console.WriteLine("    2. Create Eternal Goal");
            Console.WriteLine("    3. Create Checklist Goal");
            Console.WriteLine("    4. Back to Main Menu");
            Console.Write("Select a choice from the menu: ");

            try
            {
                _userInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please choose one of the options!");
                _userInput = 0;
            }   

            switch (_userInput)
            {
                case 1: 
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    goals.AddGoal(simpleGoal);
                    break;

                case 2: 
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goals.AddGoal(eternalGoal);
                    break;

                case 3: 
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goals.AddGoal(checklistGoal);
                    break;

                case 4: 
                    
                    break;
            }
        }
    }   
    private void DisplayShopMenu()
    {
        int _userInput = 0;
        double points;
        while (_userInput !=4)
        {
            Console.Clear();
            Console.WriteLine("Shop Options");
            Console.WriteLine("    1. Cool Sword - 500");
            Console.WriteLine("    2. College Degree - 1000");
            Console.WriteLine("    3. Pat on the back - 10000");
            Console.WriteLine("    4. Back to Main Menu");

            goals.DisplayTotalPoints();
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");


            try
            {
                _userInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please choose one of the options!");
                _userInput = 0;
            }   

            switch (_userInput)
            {
                case 1: 
                    points = 500;
                    if (ValidatePurchase(points))
                    {
                        goals.RewardPoints(-points);
                        Console.WriteLine("Congrats! You now own a sword.");
                    }

                    goals.Continue();
                    break;

                case 2: 
                     points = 1000;
                    if (ValidatePurchase(points))
                    {
                        goals.RewardPoints(-points);
                        Console.WriteLine("Congrats! You now own a college degree.");
                    }
                    
                    goals.Continue();
                    break;

                case 3: 
                    points = 10000;
                    if (ValidatePurchase(points))
                    {
                        goals.RewardPoints(-points);
                        Console.WriteLine("Congrats!");
                    }
                    
                    goals.Continue();
                    break;

                case 4: 
                    
                    break;
            }
        }
    }   
    private bool ValidatePurchase(double points)
    {
        if(goals.GetPoints() - points < 0)
        {
            Console.WriteLine("You do not have enough points to make that purchase!");
            return false;
        } else
        {
            Console.WriteLine("Purchase successful!");
            return true;
        }
    }
    
}
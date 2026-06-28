class Menu
{
    private int _parsedUserInput;

    public Menu(int parsedUserInput)
    {
        _parsedUserInput = parsedUserInput;
    }

    public void DisplayMenu()
    {
        while (_parsedUserInput != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("    1. Start Breathing activity");
            Console.WriteLine("    2. Start Reflecting activity");
            Console.WriteLine("    3. Start Listing activity");
            Console.WriteLine("    4. Start Planning activity");
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                _parsedUserInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please choose one of the options!");
            }

            switch (_parsedUserInput)
            {
                case 1: 
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    break;
                
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    break;
                case 4:
                    PlanningActivity planningActivity = new PlanningActivity();
                    planningActivity.RunActivity();
                    break;
                default: 
                    
                    break;
            }


        }
    }

    
}
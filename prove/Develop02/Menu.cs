class Menu
{
    string _optionstring;

    int _option;

    Journal _journal = new Journal();
    public void ChooseOption()
    {
        if (_option == 1)
        {
            _journal.CreateJournalEntry();
        }
        else if (_option == 2)
        {
            _journal.DisplayJournalEntry();
        }
        else if (_option == 3)
        {
            _journal.ReadFromFile();
        }
        else if (_option == 4)
        {
            _journal.WriteToFile();
        }
    }
    public void DisplayMenu()
    {
        while (_option != 5)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");

            _optionstring = Console.ReadLine();

            try
            {
                _option = int.Parse(_optionstring);

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Please choose a valid option!");
            }


            ChooseOption();

        }


    }

}
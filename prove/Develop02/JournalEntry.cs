class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk to today?"
    };
    
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        Console.WriteLine(_prompts[0]);
        _response = Console.ReadLine();
        _prompt = _prompts[0];
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date},{_prompt}, {_response}");
    }
}
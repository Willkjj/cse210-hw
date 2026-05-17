using System.ComponentModel.DataAnnotations;
using System.IO;
class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    string[] _prompts =
    {
        "How are you feeling today?",
        "Who did you talk to today?",
        "What was something you enjoyed today?",
        "What was the best thing that happened to you today?",
        "What's something you remember?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        
        Random rand = new Random();
        string randomPrompt = _prompts[rand.Next(_prompts.Length)];
        Console.WriteLine(randomPrompt); 
        
        _response = Console.ReadLine();
        _prompt = _prompts[rand.Next(_prompts.Length)];
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date:{_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine("");
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, append: true))
        {
            outputFile.WriteLine($"{_date}#{_prompt}#{_response}##");

        }
    }

}
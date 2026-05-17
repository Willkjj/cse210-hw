using System.Data;

class Journal
{
    public List<JournalEntry> _journalEntries = [];

    
    public void ReadFromFile()
    {
        bool fileFound = false;
        
        while (fileFound == false)
        {
            try
            {


                Console.WriteLine("What is the filename? ");
                string filename = "./" + $"{Console.ReadLine()}";

                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] fileEntries = line.Split("##");

                    foreach (string fileEntry in fileEntries)
                    {
                        JournalEntry entry = new JournalEntry();

                        string[] parts = line.Split("#");

                        entry._date = parts[0];
                        entry._prompt = parts[1];
                        entry._response = parts[2];
                        _journalEntries.Add(entry);
                    }

                }

                fileFound = true;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
        }


    }
    public void CreateJournalEntry()
    {
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        _journalEntries.Add(journalEntry);
    }
    
    public void DisplayJournalEntry()
    {
        foreach ( JournalEntry entry in _journalEntries)
        {
            entry.DisplayJournalEntry();
        }
    }
    public void WriteToFile()
    {
        Console.WriteLine("What would you like to name the file? ");
        string filename = Console.ReadLine();
        try
        {
            File.Delete("./" + filename);
    
        }
        catch
        {
        }

        foreach (JournalEntry entry in _journalEntries)
        {
            entry.WriteToFile(filename);
        }
        
        Console.WriteLine($"File saved as {filename}");
    }
}
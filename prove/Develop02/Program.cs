using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        journalEntry.DisplayJournalEntry();
    }
}
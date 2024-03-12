// Bradyen McAllister
// March 6, 2024
using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string bmToString()
    {
        //Formats multiple entries to be displayed in DisplayJournal
        string returnValue = "\nJournal\n";
        foreach(Entry entry in _entries)
        {
            returnValue += $"{entry.bmToString()}";
        }
        return returnValue;
    }
    public string bmToCSV()
    {
        //Formats Entries to be in a CSV
        string returnValue = "Date, Prompt, Response\n";
        foreach(Entry entry in _entries)
        {
            returnValue += entry.bmToCSV();
        }
        return returnValue;
    }
    public Journal bmFromString(string[] lines)
    {
        //makes new journal to return
        Journal journal = new Journal();
        //Receives lines a list of strings
        for (int i = 1; i < lines.Count(); i++) //skips the first line (thats why i starts as 1)
        {
            string line = lines[i];
            //Makes Entry from line
            Entry entry = new Entry();
            entry.bmFromString(line);
            //Adds entry to journal
            journal._entries.Add(entry);
        }
        return journal;
    }

}
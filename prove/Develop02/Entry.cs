// Bradyen McAllister
// March 6, 2024
using System;
using System.Globalization;
public class Entry 
{
    public string _bmDate;
    public string _bmPrompt;
    public string _bmResponse;

    public string bmToString()
    {
        //Formats a single Entry to be displayed in DisplayJournal
        string returnValue = $"{_bmDate}\nPrompt: {_bmPrompt}\n{_bmResponse}\n\n";
        return returnValue;
    }
    public string bmToCSV()
    {
        //Formats Entry to be a line in a CSV
        string dateText = _bmDate;
        string returnValue = $"{dateText}, {_bmPrompt}, {_bmResponse}\n";
        return returnValue;
    }
    public void bmFromString(string line)
    {
        // Separates a line into parts to be made into an entry
        // Separates the line into parts of Entry
        string[] parts = line.Split(", ");

        _bmDate = parts[0];
        _bmPrompt = parts[1];
        _bmResponse = parts[2];
    }
}
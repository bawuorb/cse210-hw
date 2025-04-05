using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    // Add a new journal entry
    public void AddEntry(string prompt, string response)
    {
        var entry = new Entry(prompt, response);
        entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }

        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    // Save journal entries to a file
    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved to file.");
    }

    // Load journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                var entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded from file.");
    }
}

using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    private List<Entry> JournalEntries = new List<Entry>();
    public void AddEntry(Entry e)
    {
        JournalEntries.Add(e);
        Console.WriteLine("Entry added successfully.");
    }
    public void DisplayJournal()
    {
        if (JournalEntries.Count == 0)
        {
            Console.WriteLine("No journal entries available to display.");
            return;
        }
        foreach (Entry entry in JournalEntries)
        {
            Console.Write(entry.ToString());
            Console.WriteLine();
        }
    }
    public void SaveToFile(string fileName)// creates and writes to file
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Entry item in JournalEntries)
            {
                file.WriteLine(item.GetEntryForFile());
            }
        }
        Console.WriteLine("Journal saved to file.");
    }
    public void ReadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not available");
            return;
        }
        string[] parts = File.ReadAllLines(fileName);
        foreach (string part in parts)
        {
            string[] lines = part.Split("#");
            if (lines.Length == 3)
            {
                string date = lines[0];
                string prompt = lines[1];
                string entry = lines[2];
                Entry newEntry = new Entry(date, entry, prompt);
                JournalEntries.Add(newEntry);
            }
        }
    }
    public void EditEntry()
    {
        if (JournalEntries.Count == 0)
        {
            Console.WriteLine("No entries to edit.");
            return;
        }
        Console.WriteLine("Select an entry to edit by number:");
        for (int i = 0; i < JournalEntries.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {JournalEntries[i].ShortPreview()}");
        }
        Console.Write("Your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= JournalEntries.Count)
        {
            Entry selected = JournalEntries[choice - 1];
            Console.WriteLine("\nCurrent entry:");
            Console.WriteLine(selected.ToString());
            Console.WriteLine("\nEnter your new entry text:");
            string newText = Console.ReadLine();
            selected.UpdateEntry(newText);
            Console.WriteLine("Entry updated.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
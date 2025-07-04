using System;
public class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        string menuSelection = "";

        while (menuSelection != "6")
        {
        Console.Write("Journal Program \nPlease select one of the following choices:\n1. Write New Entry \n2. Display Journal \n3. Load Journal \n4. Save Journal \n5. Edit An Entry \n6. Quit \n");
        Console.Write("What is your choice: ");

        menuSelection = Console.ReadLine();
            switch (menuSelection)
            {
                case "1":
                    // generate random prompt,
                    // ask user for their response
                // get current date
                    // Entry journalEntry = new Entry(date, prompt, response)
                    Entry journalEntry = new Entry();
                    journalEntry.RequestEntry();
                    newJournal.AddEntry(journalEntry);
                    break;

                case "2"://display entry
                    // Journal displayEntry = new Journal();
                    // displayEntry
                    newJournal.DisplayJournal();
                    // display journal
                    break;

                case "3"://load journal
                    Console.Write("What is the filename to load: ");
                    string loadFile = Console.ReadLine();
                    newJournal.ReadFromFile(loadFile);
                    break;

                case "4"://save journal
                    Console.WriteLine("filename");
                    string Savefiles = Console.ReadLine();
                    newJournal.SaveToFile(Savefiles);

                    break;
                case "5"://edit entry
                    newJournal.EditEntry();
                    break;

                case "6": // quit
                    break;
                    default:
                    Console.WriteLine("Error, select 1-5 please.");
                    break;
            }
        }
    }
}
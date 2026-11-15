
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
             
    }
    public void DisplayAll()
    {
        Console.WriteLine();
       
        foreach (Entry e in _entries)
        {
            e.Display();
        }


    }           
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file... ");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
           foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~~{e._promtText}~~{e._entryText}");

            } 
        }



    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Loading from file... ");
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
                   
            string[] parts = line.Split("~~");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promtText = parts[1];
            newEntry._entryText = parts[2];
            AddEntry(newEntry);

        }   

    }
    
}
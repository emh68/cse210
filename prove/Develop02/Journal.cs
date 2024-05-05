using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(entry._promptText);
        entry._entryText = Console.ReadLine();
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void LoadFromFile(string filename)
    {
        using (StreamReader load = new StreamReader(filename))
        {
            string line;
            while ((line = load.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Entries loaded from file successfully.");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter save = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                save.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Entries saved to file successfully.");
    }
}
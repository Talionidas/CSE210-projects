using System;

public class Journal 
{
public List <Entry> entries;
public PromptGenerator promptGenerator;

    public Journal() 
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void AddEntry() 
    {
        
        //to avoid complications with date, make user input date so there is no issue with generation of dates
        string prompt = promptGenerator.GenerateRandomPrompt();
        Console.Write("Please enter the date(mm/dd/yyyy): ");
        string dateInput = Console.ReadLine();
        Console.WriteLine($"Today's Prompt: {prompt}");
        Console.Write("> ");
        string content = Console.ReadLine();
    }

    public void DisplayEntries() 
    {
        foreach (Entry entry in entries) 
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile() 
    {
        Console.Write("Please enter the filename you would like to save to: ");
        string filename = Console.ReadLine();
        try {
            using (StreamWriter writer = new StreamWriter(filename)) {
                foreach (Entry entry in entries) {
                    writer.WriteLine($"{entry.DateCreated}\n{entry.Content}");
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
        } catch (Exception e) {
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        }
    }

    public void LoadFromFile() 
    {
        Console.Write("Please enter the file name you would like to load from: ");
        String filename = Console.ReadLine();
        try {
            using (StreamReader reader = new StreamReader(filename)) {
                while (!reader.EndOfStream) {
                    string dateString = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry entry = new Entry(dateString, content);
                    entries.Add(entry);
                }
            } 
        } 
        catch (Exception e) 
        {
                Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        }
    }

}
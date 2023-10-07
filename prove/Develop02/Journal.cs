using System.Collections;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    public string _fileName;

    public List<Entry> _entryList = new List<Entry>();

    public Journal()
    {

    }

    public void WriteEntry()
    {
        DateTime currentDateTime = DateTime.Now;
        string _formattedDate = currentDateTime.ToString("MM/dd/yyyy");

        PromptGenerator PG = new PromptGenerator();
        string _prompt = PG.ReturnPrompt();

        Console.WriteLine(_prompt);
        Console.Write("> ");

        string _response = Console.ReadLine();

        Entry _entry = new Entry();
        _entry._entryDate = _formattedDate;
        _entry._entryPrompt = _prompt;
        _entry._entryText = _response;

        _entryList.Add(_entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry _entry in _entryList)
        {
            _entry.Display();
        }
    }

    public void LoadJournal(string _fileName)
    {
        _entryList.Clear();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry _entry = new Entry();

            _entry._entryDate = parts[0];
            _entry._entryPrompt = parts[1];
            _entry._entryText = parts[2];

            _entryList.Add(_entry);
        }
    }

    public void SaveJournal(string _fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry _entry in _entryList)
            {
                outputFile.WriteLine($"{_entry._entryDate}|{_entry._entryPrompt}|{_entry._entryText}");
            }
        }
    }
}
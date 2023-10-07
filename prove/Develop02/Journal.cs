using System.Text.Json;

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
        List<Entry> _cacheList = new List<Entry>();

        _cacheList = _entryList;

        _entryList.Clear();

        string _nameOfFile = @_fileName;
        FileInfo _fileInfo = new FileInfo(_nameOfFile);
        string _extension = _fileInfo.Extension;

        if (_extension == ".json")
        {
            // I could probably put this in it's own method, but I ran out of time.

            var json = File.ReadAllText(_fileName);
            List<JsonEntry> _jsonEntryList = JsonSerializer.Deserialize<List<JsonEntry>>(json);

            foreach (JsonEntry _jsonEntry in _jsonEntryList)
            {
                Entry _entry = new Entry();

                _entry._entryDate = _jsonEntry._date;
                _entry._entryPrompt = _jsonEntry._prompt;
                _entry._entryText = _jsonEntry._text;

                _entryList.Add(_entry);
            }

            foreach (Entry _entry in _cacheList)
            {
                _entryList.Add(_entry);
            }
        }

        else
        {
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

            foreach (Entry _entry in _cacheList)
            {
                _entryList.Add(_entry);
            }
        }
    }

    public void SaveJournal(string _fileName)
    {
        string _nameOfFile = _fileName;
        FileInfo _fileInfo = new FileInfo(_nameOfFile);
        string _extension = _fileInfo.Extension;

        if (_extension == ".json")
        {
            // I could probably put this in it's own method, but I ran out of time.

            List<JsonEntry> _jsonEntryList = new List<JsonEntry>();

            foreach (Entry _entry in _entryList)
            {
                JsonEntry _jsonEntry = new JsonEntry()
                {
                    _date = _entry._entryDate,
                    _prompt = _entry._entryPrompt,
                    _text = _entry._entryText
                };

                _jsonEntryList.Add(_jsonEntry);
            }

            string _jsonString = JsonSerializer.Serialize(_jsonEntryList);
            File.WriteAllText(_fileName, _jsonString);
        }

        else
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
}
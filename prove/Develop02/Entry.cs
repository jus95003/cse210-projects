public class Entry
{
    public string _entryDate;
    public string _entryPrompt;
    public string _entryText;

    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_entryPrompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}
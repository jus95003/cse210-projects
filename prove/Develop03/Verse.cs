public class Verse
{
    // I don't quite know why yet, but these variables have to be public for the JSON Serializer/Deserializer to work right.

    public string _verseTitle { get; set; }
    public string _scriptureText { get; set; }

    public Verse()
    {

    }
}
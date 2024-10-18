public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if(_endVerse == _verse)
        {
            return _book + " " + _chapter + ":" + _verse; 
        }

        else
        {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
    }

    public static Reference ParseReference(string referencePart)
    {
        // Split into "book" and "chapter:verse"
        string[] parts = referencePart.Split(' ');

        // Get the book name
        string book = parts[0];

        // Split chapter and verse(s)
        string[] chapterVerse = parts[1].Split(':');

        // Get the chapter number
        int chapter = int.Parse(chapterVerse[0]);

        // Split the verse range
        string[] verses = chapterVerse[1].Split('-');

        // Get verse
        int startVerse = int.Parse(verses[0]);

        // Check if there's an end verse
        int endVerse;
        if (verses.Length > 1)
        {
            // Get the end verse if it exists
            endVerse = int.Parse(verses[1]);
        }
        else
        {
            // Handle if there's no end verse
            endVerse = startVerse;
        }

        // Create and return the Reference object
        return new Reference(book, chapter, startVerse, endVerse);
    }
}
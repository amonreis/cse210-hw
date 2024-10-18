using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Scripture
{
    // Reference of the scripture
    private Reference _reference;

    // List of words in the scripture
    private List<Word> _words = new List<Word>(); 

    public Scripture(Reference reference, string text)
    {
        _reference = reference; 
        // Split text into words
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Load scriptures randomly from a chosen book
    public static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptureList = new List<Scripture>(); // List to hold loaded scriptures

        // Read each line from the file
        foreach (string line in File.ReadLines(filePath))
        {
            string[] parts = line.Split(' ', 3); // Split the line into parts
            if (parts.Length < 3) continue; // Skip if line does not contain enough parts

            string referencePart = parts[0] + " " + parts[1]; // Combine "book" + "chapter":"verse"
            string text = parts[2]; // The actual scripture text

            // Parse the reference and create a Scripture object
            Reference reference = Reference.ParseReference(referencePart);
            Scripture scripture = new Scripture(reference, text);
            scriptureList.Add(scripture); // Add scripture to the list
        }

        return scriptureList; // Return the list of scriptures
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int wordsHidden = 0; wordsHidden < numberToHide; )
        {
            // Get a random index
            int randomIndex = random.Next(_words.Count);
            
            // Hide the word if it's not already hidden
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }

            // Check if all words are hidden
            if (_words.All(w => w.IsHidden()))
            {
                break; // Stop if all words are hidden
            }
        }
    }

    public string GetDisplayText()
    {
        string hiddenText = "";

        // Create the hidden text by iterating through each word in the list
        foreach (Word word in _words)
        {
            // Append each word's display text
            hiddenText += word.GetDisplayText() + " "; 
        }

        // Return formatted string
        return _reference.GetDisplayText() + "\n" + hiddenText.Trim(); 
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        // Iterate through each word to check if any are visible
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false; // Not all words are hidden
            }
            
        }
        return true; // All words are hidden
    }
}
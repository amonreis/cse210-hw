using System;

public class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_commentText}");
    }

}


using System;
using System.Collections.Generic;
using System.Text;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
    public int TotalCopies { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title, string author, string isbn, int totalCopies)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentNullException("Title cannot be empty.");
        if (totalCopies <= 0)
            throw new ArgumentOutOfRangeException("Total copies must be positive.");
        Title = title;
        Author = author;
        Isbn = isbn;
        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
    }
    public bool IsAvailable()
    {
        return AvailableCopies > 0;
    }

    public void Display()
    {
        Console.WriteLine($"{Title} by {Author} | ISBN: {Isbn} | Available: {AvailableCopies} / {TotalCopies}");
    }
}


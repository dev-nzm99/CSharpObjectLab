using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

class Library
{
    private List<Book> books;
    private List<Member> members;

    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
    }

    public void AddBook(Book b)
    {
        if (books.Exists(x => x.Isbn == b.Isbn))
        {
            Console.WriteLine("A book with this ISBN already exists.");
            return;
        }
        books.Add(b);
        Console.WriteLine("Book added succesfully.");
        return;
    }

    public void RegisterMember(Member m)
    {
        if (members.Exists(x => x.Id == m.Id))
        {
            Console.WriteLine("A member with this id already exists.");
            return;
        }
        members.Add(m);
        Console.WriteLine("Member registerd successfylly.");
        return;
    }

    private Book FindBookByIsbn(string isbn)
    {
        return books.Find(x => x.Isbn == isbn);
    }

    private Member FindMemberById(string id)
    {
        return members.Find(x => x.Id == id);
    }


    public void IssueBook(string isbn, string memberId)
    {
        Book book = FindBookByIsbn(isbn);
        Member member = FindMemberById(memberId);

        if (book == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }
        if (member == null)
        {
            Console.WriteLine("Member not found!");
            return;
        }
        if (!book.IsAvailable())
        {
            Console.WriteLine("No copies avaiable right now.");
            return;
        }

        if (member.BorrowedBooks.Count > member.BorrowLimit())
        {
            Console.WriteLine($"{member.Name} has reached their borrow limit ({member.BorrowLimit()})");
            return;
        }

        book.AvailableCopies--;
        member.BorrowedBooks.Add(book);
        Console.WriteLine($"'{book.Title}' issued to {member.Name}");
    }

    public void ReturnBook(string isbn, string memberId)
    {
        Book book = FindBookByIsbn(isbn);
        Member member = FindMemberById(memberId);

        if (book == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }
        if (member == null)
        {
            Console.WriteLine("Member not found!");
            return;
        }

        Book borrowed = member.BorrowedBooks.Find(x => x.Isbn == isbn);
        if(borrowed == null)
        {
            Console.WriteLine($"{member.Name} did not borrow this book.");
            return;
        }

        member.BorrowedBooks.Remove(borrowed);
        book.AvailableCopies++;
        Console.WriteLine($"'{book.Title}' returned by {member.Name}");
        return;
    }

    public void DisplayAvailableBooks()
    {
        bool any = false;
        foreach (Book b in books)
        {
            if (b.IsAvailable())
            {
                b.Display();
                any = true;
            }
        }
        if (!any) Console.WriteLine("No books currently available.");
    }

    public void DisplayIssuedBooks()
    {
        bool any = false;
        foreach (Member m in members)
        {
            foreach (Book b in m.BorrowedBooks)
            {
                Console.WriteLine($"{b.Title} -> issued to {m.Name} ({m.Id})");
                any = true;
            }
        }
        if (!any) Console.WriteLine("No books are currently issued.");
    }
    public void DisplayAllMember()
    {
        foreach(Member m in members)
        {
            Console.WriteLine(m.Describe());
            Console.WriteLine();
        }
        return;
    }
}
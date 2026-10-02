using System;
using System.Collections.Generic;
using System.Text;

class Member : Person
{
    public string MembershipType { get; set; }
    public List<Book> BorrowedBooks { get; private set; }

    public Member(string name, string id, string membershipType) : base(name, id)
    {
        MembershipType = membershipType;
        BorrowedBooks = new List<Book>();
    }
    
    //different membership types get diffrent borrow limits 
    public int BorrowLimit()
    {
        switch (MembershipType)
        {
            case "Premium": return 5;
            case "Regular": return 2;
            default: return 1;

        }
    }

    public override string Describe()
    {
        return $"Member: {Name} (Id: {Id}, {MembershipType}) - {BorrowedBooks.Count} books borrowed";
    }

}


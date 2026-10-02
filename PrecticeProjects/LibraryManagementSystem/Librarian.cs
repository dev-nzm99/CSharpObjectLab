using System;
using System.Collections.Generic;
using System.Text;

class Librarian : Person
{
    public string Shift { get; set; }
    public Librarian(string name, string id, string shift):base (name, id)
    {
        Shift = shift;
    }
    public override string Describe()
    {
        return $"Librarian: {Name} (Id: {Id},{Shift} shift)";
    }
}


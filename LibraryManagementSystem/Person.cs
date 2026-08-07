using System;
using System.Collections.Generic;
using System.Text;

abstract class Person
{
    public string Name { get; set; }
    public string Id { get; set; }

    protected Person(string name, string id)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException("Name cannot be empty.");
        if(string.IsNullOrEmpty(id))
            throw new ArgumentNullException("Id cannot be empty.");
        Name = name;
        Id = id;
    }

    //abstract method (every child class must implement it,s own version)
    public abstract string Describe();
}




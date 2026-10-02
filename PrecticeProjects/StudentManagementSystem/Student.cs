using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Claims;
using System.Text;
public class Student
{
    //private field (encapsulatiuon)
    private int roll;
    private string name;
    private int age;
    private double marks;

    //static fiels
    private static int totalStudents = 0;


    //properties with validations
    public int Roll
    {
        get { return roll; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Roll number must be positive!");
            }
            roll = value;
        }

    }
    public string Name
    {
        get { return name; }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Name cannot be empty!");
            name = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value <= 5 || value >= 100)
                throw new ArgumentException("Age must be between 5 and 100");
            age = value;
        }
    }
    public double Marks
    {
        get => marks;
        set
        {
            if (value <= 0 || value >= 100)
                throw new ArgumentException("Marks must be between 0 and 100.");
            marks = value;
        }
    }
    public static int TotalStudents
    {
        get => totalStudents;
        set
        {
            if (totalStudents > 0)
                totalStudents = value;
        }
    }


    // Parameterized constractor
    public Student(int roll, string name, int age, double marks)
    {
        Roll = roll;
        Name = name;
        Age = age;
        Marks = marks;
        totalStudents++;
    }

    //Method to compare grade
    public string GetGrade()
    {
        if (marks >= 80) return "A+";
        if (marks >= 70) return "A";
        if (marks >= 60) return "B";
        if (marks >= 50) return "C";
        if (marks >= 40) return "D";
        return "F";
    }

    //display method
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Roll: {Roll}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }
}


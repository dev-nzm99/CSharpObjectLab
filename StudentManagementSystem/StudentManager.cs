using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student s)
    {
        if (students.Exists(x => x.Roll == s.Roll)){
            Console.WriteLine("A student with this roll number already exists!");
            return;
        }
        students.Add(s);
        Console.WriteLine("Student added successfully.");
        return;
    }

    public void DisplayAll()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found!");
            return;
        }
        foreach (Student s in students)
        {
            s.Display();
            Console.WriteLine();
        }
    }

    public Student FindByRoll(int roll)
    {
        return students.Find(x => x.Roll == roll);
    }

    public bool UpdateMarks(int roll, double newMarks)
    {
        Student s = FindByRoll(roll);
        if (s == null) return false;
        s.Marks = newMarks;
        return true;
    }

    public bool DeleteStudent(int roll)
    {
        Student s = FindByRoll(roll);
        if (s == null) return false;
        students.Remove(s);
        Student.TotalStudents = Student.TotalStudents - 1;
        return true;
    }
}


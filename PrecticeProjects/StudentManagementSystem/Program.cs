using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========Student Management System=============");
                Console.WriteLine("1. Add student.");
                Console.WriteLine("2. Display all students.");
                Console.WriteLine("3. Search student by roll.");
                Console.WriteLine("4. Update marks.");
                Console.WriteLine("5. Delete student.");
                Console.WriteLine("6. Show total student.");
                Console.WriteLine("7. Exit.");
                Console.Write("\nEnter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter roll: ");
                                int roll = int.Parse(Console.ReadLine());
                                Console.Write("Enter name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter age: ");
                                int age = int.Parse(Console.ReadLine());
                                Console.Write("Enter marks: ");
                                double marks = double.Parse(Console.ReadLine());

                                Student newStudent = new Student(roll, name, age, marks);
                                manager.AddStudent(newStudent);
                                break;
                            }
                        case 2:
                            {
                                manager.DisplayAll();
                                break;
                            }
                        case 3:
                            {
                                Console.Write("Enter roll to search: ");
                                int roll = int.Parse(Console.ReadLine());

                                Student s = manager.FindByRoll(roll);
                                if (s != null) s.Display();
                                else Console.WriteLine("Student not found!");
                                break;
                            }
                        case 4:
                            {
                                Console.Write("Enter roll: ");
                                int roll = int.Parse(Console.ReadLine());
                                Console.Write("Enter new marks: ");
                                double newMarks = double.Parse(Console.ReadLine());

                                //if (manager.UpdateMarks(roll, newMarks)) Console.WriteLine("updated.");
                                //else Console.WriteLine("Student not found!");

                                Console.WriteLine(manager.UpdateMarks(roll, newMarks) ? "updated." : "Student not found!");
                                break;
                            }
                        case 5:
                            {
                                Console.Write("Enter roll to delete : ");
                                int delRoll = int.Parse(Console.ReadLine());
                                Console.WriteLine(manager.DeleteStudent(delRoll) ? "Deleted." : "Student not found!");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine($"Total students created: {Student.TotalStudents}");
                                break;
                            }
                        case 7:
                            running = false;
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid choice! Please try again....");
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format! please enter correct data type.");
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine($"Validation error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                }
            }
            Console.WriteLine("Program ended. Thank you!");
        }
    }
}

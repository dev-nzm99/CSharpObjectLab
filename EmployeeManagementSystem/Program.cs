using System.Globalization;
using System.Security.Cryptography;

namespace EmployeeManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            var company = new Company();
            bool runnig = true;
            while (runnig)
            {
                Console.WriteLine("=======Employee Management System=======");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display All Employee");
                Console.WriteLine("3. Display by Department");
                Console.WriteLine("4. Total Salary Expense");
                Console.WriteLine("5. Assign Employee to manager");
                Console.WriteLine("6. Show manager's team total salary");
                Console.WriteLine("7. Total employees created (static)");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Department: ");
                                string dept = Console.ReadLine();
                                Console.Write("Type (1=Full-time, 2=part-time, 3=Manager): ");
                                int type = int.Parse(Console.ReadLine());

                                if (type == 1)
                                {
                                    Console.Write("Monthly Salary: ");
                                    decimal monthlySalary = decimal.Parse(Console.ReadLine());
                                    company.AddEmployee(new FullTimeEmployee(name, dept, monthlySalary));
                                }
                                else if (type == 2)
                                {
                                    Console.Write("Hourly Rate: ");
                                    decimal hourlyRate = decimal.Parse(Console.ReadLine());
                                    Console.Write("Hourly worked: ");
                                    int workingHour = int.Parse(Console.ReadLine());
                                    company.AddEmployee(new PartTimeEmployee(name, dept, hourlyRate, workingHour));
                                }
                                else if (type == 3)
                                {
                                    Console.Write("Monthly Salary: ");
                                    decimal monthlySalary = decimal.Parse(Console.ReadLine());
                                    company.AddEmployee(new Manager(name, dept, monthlySalary));
                                }
                                else
                                {
                                    Console.WriteLine("Invalid type.");
                                }
                                break;
                            }
                        case 2:
                            {
                                company.DisplayAll();
                                break;
                            }
                        case 3:
                            {
                                Console.Write("Department: ");
                                company.DisplayByDepartment(Console.ReadLine());
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine($"Total Salary Expense: {company.GetTotalSalaryExpense():C}");
                                break;
                            }
                        case 5:
                            {
                                Console.Write("Enter employee id: ");
                                Guid employeeId = Guid.Parse(Console.ReadLine());
                                Console.Write("Enter manager id: ");
                                Guid managerId = Guid.Parse(Console.ReadLine());
                                company.AssignToManager(employeeId, managerId);
                                break;
                            }
                        case 6:
                            {
                                Console.Write("Manager id: ");
                                Guid searchMgrId = Guid.Parse(Console.ReadLine());
                                Employee found = company.FindById(searchMgrId);
                                if (found is Manager mgr)
                                {
                                    Console.WriteLine($"{mgr.Name}'s team total salary: {mgr.GetTeamTotalSalary()}");
                                }
                                else
                                {
                                    Console.WriteLine("Manager not found!");
                                }
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine($"Total employee created: {Employee.TotalEmployees}"); ;
                                break;
                            }
                        case 8:
                            {
                                runnig = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice. Try again.");
                                break;
                            }
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Invlaid input format, please enter correct data type.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Validation error: {ex.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
            Console.WriteLine("Program ended, thank you,,,");
        }
    }
}
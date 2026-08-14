
using System.Runtime.CompilerServices;

namespace EmployeeManagementSystem
{
    public class Company
    {
        private List<Employee> Employees;

        public Company()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee e)
        {
            if (Employees.Exists(x => x.Id == e.Id){
                Console.WriteLine("An employee with this id is already exists.");
                return;
            }
            Employees.Add(e);
            Console.WriteLine("Employee added successfully.");
            return;
        }

        public void DisplayAll()
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("No employees found!");
                return;
            }

            foreach (Employee e in Employees)
            {
                decimal salary = (e is IPayable payable) ? payable.CalculateSalary() : 0;
                Console.WriteLine($"{e.GetDetails()} | Salary: {salary}Tk");
            }
            return;
        }


        public void DisplayByDepartment(string dept)
        {
            bool any = false;
            foreach (Employee e in Employees)
            {
                if (e.Department.Equals(dept, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(e.GetDetails());
                    any = true;
                }
            }
            if (!any) Console.WriteLine("No employees found in this department.");
            return;
        }


        public decimal GetTotalSalaryExpense()
        {
            decimal total = 0;
            foreach (Employee e in Employees)
            {
                if (e is IPayable payable) {
                    total += payable.CalculateSalary();
                }
            }

            return total;
        }

        public Employee FindById(Guid id)
        {
            return Employees.Find(x => x.Id == id);
        }

        public void AssignToManager(Guid employeeId, Guid managerId)
        {
            Employee emp = FindById(employeeId);
            Employee mgrCandidate = FindById(managerId);

            if (emp == null) { Console.WriteLine("Employee not found."); return; }
            if (mgrCandidate == null) { Console.WriteLine("Manager not found."); return; }

            if (mgrCandidate is Manager manager)
            {
                manager.AddTeamMember(emp);
                Console.WriteLine($"{emp.Name} assigned to {manager.Name}'s team.");
            }
            else
            {
                Console.WriteLine($"{mgrCandidate.Name} is not a manager.");
            }
            return;
        }

    }
}

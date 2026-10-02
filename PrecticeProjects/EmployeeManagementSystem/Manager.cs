
using System.Security.Principal;

namespace EmployeeManagementSystem
{
    public class Manager : Employee, IPayable
    {
        public decimal MonthlySalary { get; set; }
        public List<Employee> TeamMembers { get; private set; }

        public Manager(string name, string department, decimal monthlySalary) : base(Guid.NewGuid(), name, department)
        {
            if (monthlySalary <= 0)
                throw new ArgumentException("Monthly salary must be positive.");

            MonthlySalary = monthlySalary;
            TeamMembers = new List<Employee>();
        }

        public decimal CalculateSalary()
        {
            return MonthlySalary;
        }

        public void AddTeamMember(Employee e)
        {
            if (e.Id == this.Id)
            {
                Console.WriteLine("A manager cannot add itself to its own team.");
                return;
            }
            if (TeamMembers.Exists(x => x.Id == e.Id))
            {
                Console.WriteLine("This employee is already exists in this team.");
                return;
            }

            TeamMembers.Add(e);
            Console.WriteLine("Member added succesfully.");
            return;
        }

        public decimal GetTeamTotalSalary()
        {
            decimal total = 0;

            foreach (Employee e in TeamMembers)
            {
                if (e is IPayable payable)
                {
                    total += payable.CalculateSalary();
                }
            }

            return total;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $"(Manager, team size: {TeamMembers.Count})";
        }
    }
}

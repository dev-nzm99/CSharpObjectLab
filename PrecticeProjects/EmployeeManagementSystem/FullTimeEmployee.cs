using System.Xml.Schema;

namespace EmployeeManagementSystem
{
    public class FullTimeEmployee :Employee , IPayable
    {
        public decimal MonthlySalary { get; set; }
        public FullTimeEmployee(string name,string department, decimal monthlySalary):base(Guid.NewGuid(),name,department) 
        {
            if (monthlySalary <= 0)
                throw new ArgumentException("Monthly salary must be positive.");
        
            MonthlySalary = monthlySalary;
        }

        public decimal CalculateSalary()
        {
            return MonthlySalary;
        }
        public override string GetDetails()
        {
            return base.GetDetails() + " Full-Time";
        }
    }
}


namespace EmployeeManagementSystem
{
    public class PartTimeEmployee : Employee, IPayable
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public PartTimeEmployee(string name, string department, decimal hourlyRate, int hoursWorked) : base(Guid.NewGuid(), name, department)
        {
            if (hourlyRate < 0)
                throw new ArgumentException("Hourly rate cannot be nagative.");
            if (hoursWorked < 0)
                throw new ArgumentException("Hours worked cannot be negative.");
            
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        public decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
        public override string GetDetails()
        {
            return base.GetDetails() + " Part-Time";
        }
    }
}

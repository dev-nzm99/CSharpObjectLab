namespace EmployeeManagementSystem
{
    public abstract class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public static int TotalEmployees { get; private set; } = 0;
        public Employee(Guid id, string name, string department)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be empty.");
            if (string.IsNullOrWhiteSpace(department))
                throw new ArgumentNullException("Departmnt cannot be empty.");

            Id = id;
            Name = name;
            Department = department;
            TotalEmployees++;
        }

        public virtual string GetDetails()
        {
            return $"[{Id}] {Name} - {Department}";
        }
    }
}

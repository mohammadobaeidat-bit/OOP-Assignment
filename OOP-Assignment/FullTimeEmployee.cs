class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, decimal monthlySalary)
        : base(id, name)
    {
        Salary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return Salary;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working full-time.");
    }
}
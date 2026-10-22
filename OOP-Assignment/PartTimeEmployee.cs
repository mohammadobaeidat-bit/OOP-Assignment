class PartTimeEmployee : Employee
{
    public int HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }

    public PartTimeEmployee(
        int id,
        string name,
        int hoursWorked,
        decimal hourlyRate)
        : base(id, name)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working part-time.");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new FullTimeEmployee(1, "Ahmad", 1200);

        Employee emp2 = new PartTimeEmployee(2, "Omar", 40, 10);

        emp1.DisplayInfo();

        Console.WriteLine("--------------------");

        emp2.DisplayInfo();

        Console.WriteLine("--------------------");

        emp1.Work();
        emp2.Work();
    }
}
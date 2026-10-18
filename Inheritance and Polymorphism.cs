using System;
class Employee
{
    public double BaseSalary { get; set; } = 40000;
    public virtual void CalculateSalary()
    {
        Console.WriteLine($"Employee Salary: ${BaseSalary}");
    }
}
class Manager : Employee
{
    public double Bonus { get; set; } = 15000;
    public override void CalculateSalary()
    {
        double total = BaseSalary + Bonus;
        Console.WriteLine($"Manager Salary (with bonus): ${total}");
    }
}
class Program
{
    static void Main()
    {
        Employee e = new Employee();
        e.CalculateSalary();
        Manager m = new Manager();
        m.CalculateSalary();
    }
}


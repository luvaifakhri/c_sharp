using System;
class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    // Constructor
    public Employee(int id, string name, double salary)
    {
        EmployeeId = id;
        Name = name;
        Salary = salary;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {Salary}");
    }
}
class Program
{
    static void Main()
    {
        Employee emp1 = new Employee(101, "Alice Smith", 55000);
        Employee emp2 = new Employee(102, "Bob Jones", 62000);

        emp1.DisplayDetails();
        emp2.DisplayDetails();
    }
}


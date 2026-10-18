using System;
using System.Collections.Generic;
class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        // Add records
        students.Add(new Student { RollNo = 1, Name = "Alice" });
        students.Add(new Student { RollNo = 2, Name = "Bob" });
        // Display records
        Console.WriteLine("--- Student List ---");
        foreach (Student s in students)
        {
            Console.WriteLine($"Roll: {s.RollNo}, Name: {s.Name}");
        }
    }
}



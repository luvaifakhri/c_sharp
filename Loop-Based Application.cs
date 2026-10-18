using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number for its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"\nMultiplication Table of {num}:");
        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
}


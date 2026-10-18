using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Numerator: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Denominator: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integer numbers.");
        }
        finally
        {
            Console.WriteLine("Execution of try-catch completed.");
        }
    }
}

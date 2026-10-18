using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Math marks: ");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Science marks: ");
        int sci = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter English marks: ");
        int eng = Convert.ToInt32(Console.ReadLine());
        
        int total = math + sci + eng;
        double pct = (double)total / 3;
        
        Console.WriteLine($"Total: {total} | Percentage: {pct:F2}%");
        
        if (pct >= 80)
            Console.WriteLine("Grade: A");
        else if (pct >= 60)
            Console.WriteLine("Grade: B");
        else if (pct >= 40)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: Fail");
    }
}


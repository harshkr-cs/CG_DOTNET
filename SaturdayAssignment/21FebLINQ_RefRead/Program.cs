// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
//No usage
// using System.ComponentModel;
// using System.Diagnostics.Metrics;
// using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
         List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Arun", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Meera", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "John", Department = "IT", Salary = 75000 }
        };

        var result = employees
                        .Where(e => e.Salary > 50000)   // Filter
                        .GroupBy(e => e.Department)     // Group
                        .ToDictionary(
                            g => g.Key,
                            g => g.ToList()
                        );

        // Print Output
        foreach (var dept in result)
        {
            Console.WriteLine(dept.Key + " → " +
                string.Join(", ", dept.Value.Select(e => e.Name)));
        }
        
        Console.WriteLine("===== NORMAL PARAMETER =====");
        int a = 10;
        NormalMethod(a);
        Console.WriteLine($"After NormalMethod: {a}");
        Console.WriteLine();

        Console.WriteLine("===== REF PARAMETER =====");
        int b = 10;
        RefMethod(ref b);
        Console.WriteLine($"After RefMethod: {b}");
        Console.WriteLine();

        Console.WriteLine("===== REF READONLY PARAMETER =====");
        int c = 10;
        RefReadonlyMethod(ref c);
        Console.WriteLine($"After RefReadonlyMethod: {c}");
        Console.ReadLine();
    }


    static void NormalMethod(int number)
    {
        number = number + 5;
        Console.WriteLine($"Inside NormalMethod: {number}");
    }

    //2)ref parameter (can modify original)
    static void RefMethod(ref int number)
    {
        number = number + 5;
        Console.WriteLine($"Inside RefMethod: {number}");
    }

    //3)ref readonly parameter (cannot modify original)
    static void RefReadonlyMethod(ref readonly int number)
    {
        Console.WriteLine($"Inside RefReadonlyMethod: {number}");

        // number = number + 5; //Compile-time error
    }
}

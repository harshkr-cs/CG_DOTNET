// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main()
    {
        Assembly assembly = Assembly.Load("MyLibrary");//Load MyLibrary dll

        var types = assembly.GetTypes();

        var interfaces = types.Where(t => t.IsInterface);
        var classes = types.Where(t => t.IsClass);

        Console.WriteLine($"Number of Interfaces: {interfaces.Count()}");
        Console.WriteLine($"Number of Classes: {classes.Count()}");

        foreach (var type in types)
        {
            var methods = type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly
            );

            Console.WriteLine($"\nType: {type.Name}");
            Console.WriteLine($"Methods Count: {methods.Length}");

            foreach (var method in methods)
            {
                Console.WriteLine($" - {method.Name}");
            }
        }
    }
}

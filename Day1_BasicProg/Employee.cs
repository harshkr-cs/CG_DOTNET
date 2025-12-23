using System;


namespace HelloWorldApp{
    class Employee{
        int Id;
        string Name;
        string Department;
        float Salary;
        char Gender;

        public void AcceptDetails(){
            Console.WriteLine("Enter Employee Id:");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Department:");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            Salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Employee Gender:");
            Gender = Convert.ToChar(Console.ReadLine());
        }

        public void DisplayDetails(){
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Department: " + Department);
            Console.WriteLine("Employee Salary: " + Salary);
            Console.WriteLine("Employee Gender: " + Gender);
        }
    }

}

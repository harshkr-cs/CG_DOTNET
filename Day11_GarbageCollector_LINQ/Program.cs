// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
// using System.LINQ;
class Programme{
    public static void Main(string[] args){
        //Garbage collector
        // Garbage.xyz();
        //Tuples->Groupoing multiple value togher
        // (int,string) student1=(101,"Amit");
        // Console.WriteLine(student1.GetType());
        // var student2=(Id:101,Name:"Amit");
        // Console.WriteLine(student2.GetType());
        
      //Multiple value return using Tuple
    //   static (int Sum,int Average,int Difference) Calculate(int a,int b){
    //        return (a+b,((a+b)/2),(a-b));
    //   }
    //   Console.WriteLine(Calculate(10,5));

    //   static (bool IsValid,string name) ValidateUser(string username){
    //     if(string.IsNullOrEmpty(username)){
    //         return (false,"User is required");
    //     }

    //     return (true,"Valid User");
    //   }
    //    Console.WriteLine(ValidateUser(""));

       //deconstructing a Tuple
    //    var person=(Id:1,Name:"Neha");//creating a Tuple
    //    //Direct access of Tuple element
    //    Console.WriteLine(person.Id);//1
    //    Console.WriteLine(person.Name);//Neha
    //    Console.WriteLine(person.Id.GetType());//System.Int32->Get which type of data it has
       
       //deconstructing Tuple
    //    var(id,name)=person;
    //    Console.WriteLine(id);//1
    //    Console.WriteLine(name);//Name
    //    Console.WriteLine(id.GetType());//System.Int32->which type of data it has

       //*Using Discards
    //    var (_,userName)=person;
       
        // _ is called a discard
        // Used when a value is not required
        // Id is ignored
        // Only Name is assigned to userName

        // var s = new Student { Id = 1, Name = "Amit" };
        // Console.WriteLine(s.GetType());//Student
        // var (sid, sname) = s;

        // Console.WriteLine(sid);//1
        // Console.WriteLine(sname);//Amit

        //Anonymous type
        // var a=new {x=10,y=20};
        // Console.WriteLine(a.GetType());

        //LINQ
        // int[] numbers={1,2,3,4,5,6,7,8};

        // var evenNumbers=numbers.Where(n => n%2 == 0);//LINQ
        // Console.WriteLine(evenNumbers.GetType());//IEnumerable Interface
        // Console.WriteLine("Even numbers are: ");
        // foreach(var num in evenNumbers){
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();

        // var isGreater=numbers.Where(n => n>3).Select(n=>n*2);
        // Console.WriteLine("Numbers greater than 3 are: ");
        // Console.WriteLine();
        // Console.WriteLine(isGreater.GetType());//IEnumerable Interface
        //  foreach(var num in isGreater){
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();
        
        // List<Student> students = new List<Student>(){
        //     new Student (Name:"Harsh Kumar",Marks:95),
        //     new Student (Name:"Vaibhav Thakur",Marks:96),
        //     new Student (Name: "Tirtharaj",Marks:98)
        // };
        // //create three objects and assign them value
        // var result=students.Select(s => new
        // {
        //     s.Name,
        //     Grade=s.Marks>60 ? "Pass" : "Fail"
        // });
        // Console.WriteLine(result.GetType());

        // List<int> numbers=new List<int>{5,2,8,1,3};
        // var ascending=numbers.OrderBy(n => n);
        // foreach(int num in ascending){
        //     Console.Write(num + " ");//1 2 3 5 8 
        // }
        // Console.WriteLine();
        // var descending=numbers.OrderByDescending(n => n);
        //  foreach(int num in descending){
        //     Console.Write(num + " ");//8 5 3 2 1 
        // }
        // Console.WriteLine();

        // List<Employee> emp=new List<Employee>{
        //     new Employee {Name = "Amit",Salary=50000},
        //     new Employee {Name = "Ravi",Salary=70000},
        //     new Employee {Name = "Neha",Salary=60000}
        // };
        // var sortedBySalary=emp.OrderBy(e => e.Salary);
        // foreach(var e in sortedBySalary){
        //     Console.WriteLine(e.Name +" "+ e.Salary);
        // }

        // ResourceHandler rh=new ResourceHandler();
        // rh.Dispose();
        // using (ResourceHandler handler = new ResourceHandler()){
        //     Console.WriteLine("Using resource...");
        // }//Dispose() called automatically
        // Console.WriteLine("End of Program.");

        // Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        // for (int i = 0; i < 10000; i++)
        // {
        //     object obj = new object(); // Gen 0 allocation
        // }

        // Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        // GC.Collect(); 
        // GC.WaitForPendingFinalizers();

        // Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        // Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");

    }
}
//where do we use Tuple
// using System;

// class BankAccount
// {
//     private double balance;   

//     public void Deposit(double amount)
//     {
//         if (amount > 0)
//         {
//             balance += amount;
//         }
//         else
//         {
//             Console.WriteLine("Amount can't be negative.");
//         }
//     }

//     public void Withdraw(double amount)
//     {
//         if (amount > 0 && amount <= balance)
//         {
//             balance -= amount;
//         }
//         else
//         {
//             Console.WriteLine("Invalid withdrawal amount.");
//         }
//     }

//     public double GetBalance()
//     {
//         return balance;
//     }
// }

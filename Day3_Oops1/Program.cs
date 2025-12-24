// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Oops{
    
    public static void Process(){
        string status = "Processing...";

        void PrintMsg(){
            Console.WriteLine(status);
        }

        PrintMsg();
    }

    public static void Calculate(int a,int b){
        void Add(){
            Console.WriteLine(a+b);
        }
         void Substract(){
            Console.WriteLine(a-b);
        }
        Add();
        Substract();
    }
    
    //lamda function example
    public static void Example(){
        int Square(int x){
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;

        Console.WriteLine(Square(4));
        Console.WriteLine(squareLambda(4));
   }

   public static void Calculate1(){
    int number = 5;

    static int Square(int x)
    {
        return x * x;
    }

    Console.WriteLine(Square(number));
}


    public static void Main(string[] args){
        //creation of object
        // BankAccount acc1 = new BankAccount();
        // //initialization of members
        // acc1.accountNum = 12345;
        // // acc1.balance = 1000.50;
        // //displaying values
        // Console.WriteLine("Account Number: " + acc1.accountNum);
        // // Console.WriteLine("Balance: " + account1.balance);
        // acc1.Deposit(500.75);


        // Employee emp1=new Employee();
        // emp1.name="John Doe";   
        // emp1.salary=55000.75f;

        // emp1.DisplayInfo();

        // Wallet myWallet=new Wallet();
        // myWallet.AddMoney(150.75);
        // Console.WriteLine("Wallet Balance: " + myWallet.GetBalance());
        
        //calling static method of calculator class
        // int sum=Calculator.Add(10,20);
        // Console.WriteLine("Sum: " + sum);

        //method overloading
        // Calculator calc=new Calculator();
        // int sum2=calc.Add(15,25);
        // Console.WriteLine("Sum of 2 integers: " + sum2);
        // int sum3=calc.Add(10,20,30);
        // Console.WriteLine("Sum of 3 integers: " + sum3);
        // double sumD=calc.Add(10.5,20.3);
        // Console.WriteLine("Sum of 2 doubles: " + sumD);

        // double sum2=calc.Add(15.5,25);
        // Console.WriteLine("Sum of 2 integers: " + sum2);

        // Person p1=new Person();
        // p1.Person1("Alice",25,'F');  
        // p1.Person2();
        // p1.Person2(name:"David",age:28,gen:'M');
        // p1.Person3("Bob",30);
        // p1.Person4("Reading","Traveling","Gaming");

        // int[] numbers={10,20,30,40,50};
        // foreach(int num in numbers){
        //     Console.Write(num+" ");
        // }

        // int[] numbers={10,20,30,40,50};
        // p1.sum(numbers);//using array
        // p1.sum1(5,15,25,35,45);//using params keyword
        
        //pass by reference using ref keyword
        // int val=10;
        // Console.WriteLine("Before Increase: "+val);
        // Keyword kw=new Keyword();   
        // kw.Increase1(ref val);
        // Console.WriteLine("After Increase: "+ val);//change in original value
        
        //pass by value
        // int val=10;
        // Console.WriteLine("Before Increase: "+val);
        // Keyword kw=new Keyword();   
        // kw.Increase2(val);
        // Console.WriteLine("After Increase: "+ val);//change in copy value not original value

        //out keyword=>Used to return multiple values from a method.
        // int q, r;   // no initialization required
        // Keyword kw=new Keyword(); 
        // kw.Divide(10, 3, out q, out r);
        // Console.WriteLine("Quotient = " + q);
        // Console.WriteLine("Remainder = " + r);

        // string grade;//no initialization required
        // kw.GetResult(75, out grade);    
        // Console.WriteLine("Grade: " + grade);
        
        //in keyword=>Pass read-only reference to a method
        // int num = 50;
        // Keyword kw=new Keyword();
        // kw.Print(in num);   
        
        // Keyword kw=new Keyword();
        // kw.sum(5);
        // kw.sum1({5,15,25,35});//give error 

        // Oops.Process();
        // Oops.Calculate(20,10);
        // Oops.Example();
        // Oops.Calculate1();
        
        // Test.Calculate();

        // int n = int.Parse("100");
        // Console.WriteLine(n); // 100

        // int value;
        // bool success = int.TryParse("abc", out value);

        // Console.WriteLine(success); // False
        // Console.WriteLine(value);   // 0

        // int n = int.Parse("20"); // Runtime error

        // BankAccount acc1 = new BankAccount();
        // acc1.Deposit(1000);
        // acc1.withdraw(500);

        //constructor->constructor is a method that initilise the object
        // Bank bank1=new Bank();
        // FixedDeposit fd1=new FixedDeposit();
        // fd1.timePeriod=5;
        // fd1.balance=100000;
        // fd1.ROI=7.25;

        // Product p = new Product{
        //     Name = "Laptop",
        //     Price = 50000
        // };

       

        // Encapsulation acc = new Encapsulation();
        //directly access using getter and setter methods
        // acc.Deposit(5000);
        // Console.WriteLine("Balance: " + acc.GetBalance());

        //access using properties
        // acc.Deposit(5000);
        // Console.WriteLine("Balance: " + acc.Balance);
        // acc.Withdraw(2000);
        // Console.WriteLine("Balance: " + acc.Balance);

        // acc.Balance = 1000; //Not allowed

    
        // Student s1 = new Student();
        // s1.Name = "Harsh Kumar";
        // s1.Age = 21;
        // s1.Marks=95;
        // Console.WriteLine(s1.Result);
        // s1.Password = "1";
        
        //init example
        //Allowed (Object Initialization) like this only
        // Student s = new Student{
        // RollNo = 101,
        // name1 = "Harsh"
        // };
        //Not Allowed (Compile-time error)->(After Object Creation)
        // s.RollNo = 102;   
        // s.Name = "Amit"; 


      //indexer example
    //   Student sc = new Student();
    //   sc[0] = "Amit";             // Valid: index 0
    //   sc[5] = "Zeeshan";          // Invalid: index 5 (Ignored by set)

    //   Console.WriteLine(sc[0]);   // Output: Amit
    //   Console.WriteLine(sc[5]);   // Output: Invalid Index

    //   EmployeeDirectory ed = new EmployeeDirectory();
    //   ed[101] = "Ravi";

    //   Console.WriteLine(ed[101]);
    //   Console.WriteLine(ed["Ravi"]);

        // PART 5: Usage Task=>LMS
        // Library library = new Library();

        // // Add books using integer indexer
        // library[101] = "C# Basics";
        // library[102] = "ASP.NET Core";
        // library[103] = "Data Structures";

        // // Retrieve using Book ID
        // Console.WriteLine(library[101]);
        // Console.WriteLine(library[102]);

        // // Retrieve using Book Title
        // Console.WriteLine(library["C# Basics"]);
        // Console.WriteLine(library["Java Programming"]); // Not found case

        //------------------------------INHERITANCE------------------------------
        // Car c1=new Car();
        // c1.Start();
        // c1.Drive();

        // Student1 st1=new Student1("Harsh Kumar",101);
        // Console.WriteLine("Name: "+st1.Name);
        // Console.WriteLine("Roll No: "+st1.RollNo);
        // Employees emp1=new Employees();
        // emp1.Breathe();
        // emp1.Think();
        // emp1.Work();
        
        //interface example->multiple inheritance
        // Machine m1=new Machine();
        // m1.Print(); 
        // m1.Scan();

        //------------------------------POLYMORPHISM------------------------------
        //Method Overloading
        MethodOverloading mo=new MethodOverloading();
        int sum1=mo.Add(10,-5);
        Console.WriteLine("Sum of 2 integers: " + sum1);
        double sum2=mo.Add(10.5,-5.3);
        Console.WriteLine("Sum of 2 doubles: " + sum2);
        int sum3=mo.Add(10,20,30);
        Console.WriteLine("Sum of 3 integers: " + sum3);
        string concat= mo.Add("Harsh","Kumar");
        Console.WriteLine("Concatenated String: " + concat);
        
        
        // Compile-time Polymorphism(Method Overloading) already shown in Calculator class
        //Method Overriding
        // Animal myAnimal = new Animal(); // Animal object
        // Animal myDog = new Dog();     // Dog object treated as Animal   
        // myAnimal.Sound(); // Outputs: Animal makes sound
        // myDog.Sound();    // Outputs: Dog barks

        // Animal myDog1 = new Dog1(); 
        // myDog1.Sound();   // Outputs:Animal makes sound

        Drawing d;

        d = new Circle();
        Console.WriteLine("Circle Area: " + d.Area());

        d = new Square();
        Console.WriteLine("Square Area: " + d.Area());

        d = new Rectangle();
        Console.WriteLine("Rectangle Area: " + d.Area()); 


        //------------------------------ABSTRACTION------------------------------
        // Banking bank=new SavingAccount();
        // bank.AccountType();
        // double interest=bank.CalculateInterest();


      
      




    } 
}
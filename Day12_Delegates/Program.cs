// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Text;
using System.Collections.Generic;
using SmartHomeSecurity;
using CallbackDemo;
// using System.LINQ;
class Programme{
            // STEP 4: The actual Callback Method
        static void DisplayNotification(string file){
            Console.WriteLine($"NOTIFICATION: You can now open {file}.");
        }
   delegate void ErrorDelegate(string message);
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
        //-------------------string,stringbuilder,stringbuffer-----------------------
        StringDemo s=new StringDemo();
        // s.StringBuilderEx();
        // //Memory usage check
        // Console.WriteLine("Before string builder memory usage: " + GC.GetTotalMemory(false));
        // StringBuilder sb= new StringBuilder();
        // for(int i = 0; i < 10000; i++){
        //         sb.Append(i);
        //  }
        // Console.WriteLine("After string builder memory usage: " + GC.GetTotalMemory(false));
        
        //StringBuilder does NOT override Equals()
        //Equals() performs reference comparison, not content comparison
        //== Compares values or references, depending on the type AND Behavior can be overloaded by a class
        //Default Behavior:i)Value types → compares values
        //               ii)Reference types → compares references (memory address)

      //   StringBuilder sb1 = new StringBuilder("Hello");
      //   StringBuilder sb2 = new StringBuilder("Hello");
        
      //   Console.WriteLine("sb1.Equals(sb2): " + sb1.Equals(sb2));//True
      //   Console.WriteLine("object.ReferenceEquals(sb1, sb2): " + object.ReferenceEquals(sb1, sb2));//False

      //   StringBuilder sb3 = sb2;    //* No new obj created
      //   Console.WriteLine("sb3.Equals(sb2): " + sb3.Equals(sb2));
      //   Console.WriteLine("object.ReferenceEquals(sb3, sb2): " + object.ReferenceEquals(sb3, sb2));
      //   Console.WriteLine($"sb1 == sb2: {sb1 == sb2}");     //* for sb it behaves like ReferenceEquals

      //   string str1 = "hello";
      //   string str2 = "hello";
      //   Console.WriteLine("str1 == str2: " + (str1 == str2));       //* compares content 
      //   Console.WriteLine("str1.Equals(str2): " + str1.Equals(str2));   //* also compare content
      //   Console.WriteLine(object.ReferenceEquals(str1, str2));

      //---------------------------------------delegate------------------------------------------------------------------
      // PaymentService service=new PaymentService();//object creation 
      // //single delegates
      // PaymentDelegate payment=service.ProcessPayment;//Assigning method to delegate
      // payment(5000);//Invoking the delegate
      
      // decimal amount=5000;
      // if(amount.IsValidPayment()){
      //    payment(amount);
      // }else{
      //    Console.WriteLine("Invalid amount");
      // }
      
      //multicast delegate
      // NotificationService service1=new NotificationService();
      // OrderDelegate notify=null;
      // notify += service1.SendEmail;
      // notify += service1.SendSMS;

      // notify("ORD1001");
      
      //Action delegates
      // Action<string> logActivity= message => Console.WriteLine("Log Entry: "+ message);
      // logActivity("User loggged in at 10:30 AM");

      //func delegates
      // Func<decimal,decimal,decimal> calculateDiscount=
      // (price,discount) => price - (price*discount/100);
      // T1 → decimal price
      // T2 → decimal discount
      // TResult → decimal return value
      // Last type is always the return type

      //Console.WriteLine("Function delegates return: " + calculateDiscount(1000,10));

      //predicate delegates->return a boolean value and take only 1 argument.Used for validation & filtering
      // Predicate<int> isEligible= age => age>=18;
      // Console.WriteLine(isEligible(17));

     //Anonymus delegates
   //   delegate void ErrorDelegate(string message);
   //   ErrorDelegate errorHandler=delegate(string msg){
   //      Console.WriteLine("Error: " + msg);
   //   };
   //   errorHandler("File not found.");
     
     //delegate+event example  
     //Button btn=new Button();
     //step4:Subscribe a method to the event
      // btn.Clicked += () => Console.WriteLine("Button was Clicked.");
      // btn.Clicked += () => Console.WriteLine("Show message on screen");
      // btn.Clicked += () => Console.WriteLine("Play click sound");
      // btn.Clicked += () => Console.WriteLine("Save click log");

      //btn.Clicked += btn.ShowMessage;
      //btn.Clicked += btn.PlaySound;
      //btn.Clicked += btn.SaveLog;
      
      //step5:Trigger the eevnt
      //btn.Click();

      // Objects Initialization
      //MotionSensor livingRoomSensor = new MotionSensor();
      // AlarmSystem siren = new AlarmSystem();
      // PoliceNotifier police = new PoliceNotifier();

      // // 2. INSTANTIATION & MULTICASTING
      // // We "Subscribe" different methods to the sensor's delegate
      // SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
      // panicSequence += police.CallDispatch;

      // //Linking the sequence to the sensor
      // livingRoomSensor.OnEmergency = panicSequence;
	   // //class_object.delegate_instance = delegate_instance_multicast

      // // Simulation
      // livingRoomSensor.DetectIntruder("Main Lobby");

       FileDownloader downloader = new FileDownloader();

      //Pass the method 'DisplayNotification' as a callback
      downloader.DownloadFile("Presentation.pdf", DisplayNotification);

      //Comparison generic delegates
      Comparison<int> sortDescending= (a,b) => b.CompareTo(a);
      Console.WriteLine(sortDescending(5,10));
      Console.WriteLine(sortDescending(10,5));
      Console.WriteLine(sortDescending(5,5));
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

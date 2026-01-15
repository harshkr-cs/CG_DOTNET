// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Threading;//For Threading
using System.Threading.Tasks;//For Parallel class + Task
using System.Diagnostics;//For Process

class Programme{
   
   static void PrintMessage(object message){
    Console.WriteLine(message);
   }


    static void DoWork(){
        for (int i = 1; i <= 5; i++){
            Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(1000);
        }
    }
    
    //Here Race condition Problem occur
    static int counter=0;//for thread demonstartion
    static void Increment(){
        for(int i=0;i<1000;i++){
            counter++;
        }
        //Console.WriteLine(counter);
    }
    //Here lock is used to remove Race condtion Problem so unpredictable problem not occur
    static int counter1=0;
    static object lockObj=new object();
    static void Increment1(){
        for(int i=0;i<1000;i++){
            lock(lockObj){
                counter1++;
            }
        }
        //Console.WriteLine(counter);
    }

    static public void Main(string[] args){
         //Thread with Parameter
       //Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
        //thread.Start("Hello from thread");

       //Thread without parameter
        // Thread worker = new Thread(DoWork);
        // worker.Start();
        // Console.WriteLine("Main thread continues...");
      
      //Basic parallel Loop
      //Parallel.For(start,end,body);
    //   All iterations run inside the same process
    //   But they may run on different threads
    //   And those threads may execute on multiple CPU cores
    //   Parallel.For(0,5,i => {
    //     Console.WriteLine("Procesing item " + i);
    //   });

    // int[] numbers=new int[10];
    // for(int i=0;i<numbers.Length;i++){
    //     numbers[i] =i+1;
    // }
    //PART 1: NOT Thread-Safe (Race Condition)=>unpredictable
    // int sum1=0;//sum1 is a shared variable
    // Parallel.For(0,numbers.Length,i => {
    //      sum1 += numbers[i];//not thread safe(for demonstrations)
    // });
    // Console.WriteLine(sum1);
    
    //PART 2: Thread-Safe Using Thread-Local Variables=>always correct
    //int sum2=0;
    // Parallel.For(
    //     0,
    //     numbers.Length,
    //     () => 0,    //initilisation localSum to 0 => //Thread-local initialization
    //     (i,loopState,localSum) =>
    //     {
    //         return localSum + numbers[i];
    //     },
    //     localSum =>
    //     {
    //         Interlocked.Add(ref sum2,localSum);//Interlocked.Add ensures atomic operation | Safely merges results into sum2
    //     }
    // );
    // Console.WriteLine(sum2);

        // Create a new thread
        // Thread worker = new Thread(DoWork);
        // // Start the thread
        // //OS schedules the worker thread
        // //DoWork() runs in parallel with Main
        // worker.Start();
        // Console.WriteLine("Main thread continues...");
        // // Optional: Wait for worker thread to finish
        // //Main thread blocks
        // //Waits until worker finishes
        // worker.Join();//“Join() blocks the calling thread until the target thread finishes execution.”
        // Console.WriteLine("Main thread finished");

        //Example:Get current Process
        // Process currentProcess=Process.GetCurrentProcess();
        // Console.WriteLine("Process Id: " + currentProcess.Id);
        // Console.WriteLine("Process Name: " + currentProcess.ProcessName);
        // Console.WriteLine("Process StartTime: "+ currentProcess.StartTime);
        // Console.WriteLine("Process Threads: "+ currentProcess.Threads);
        // Console.WriteLine("Process Memory Usage: "+ currentProcess.WorkingSet64);
        // Console.WriteLine("Process usageTime: "+ currentProcess.TotalProcessorTime);
        
        //Process.Start("notepad.exe");open the notepad 
        
        //Race codition problem occur here
        // Thread t1=new Thread(Increment);
        // Thread t2=new Thread(Increment);
        // t1.Start();
        // t2.Start();
        // t1.Join();
        // t2.Join();

        // Console.WriteLine("Final Counter Value: "+counter);
       
       //lock:solve Race codition problem so unpredictable result for shared variable not come 
        // Thread t1=new Thread(Increment1);
        // Thread t2=new Thread(Increment1);
        // t1.Start();
        // t2.Start();
        // t1.Join();
        // t2.Join();

        // Console.WriteLine("Final Counter Value: "+counter1);

        //Task
        try{
            //Task Creation
            Task t=Task.Run(() => throw new Exception("Task Error"));
            t.Wait();//Blocking Call
        }catch(AggregateException ex){//Task exceptions are wrapped
            Console.WriteLine(ex.InnerExceptions[0].Message);
        }
        
        //waiting for multiple tasks with Task.WhenAll
        //chaining+combining+continuewith
        Task t1=Task.Run(() => Console.WriteLine("Task 1"));
        Task t2=Task.Run(() => Console.WriteLine("Task 2"));

        Task.WhenAll(t1,t2).ContinueWith(t => Console.WriteLine("All task completed."));
        Console.ReadLine();

        Task<int> t=Task.Run(() => 42);
        
       




    }
  

    //async | await
    // static async Task Main(string[] args){
    //     // Console.WriteLine("Main start");
    //     // await DoWorkAsync();
    //     // Console.WriteLine("Main end");
        
    //     Console.WriteLine("Start reading File...");
    //     string content=await File.ReadAllTextAsync("data.txt");
    //     Console.WriteLine("File content: " +content);

    // }

    // static async Task DoWorkAsync(){
    //     Console.WriteLine("Work started");
    //     await Task.Delay(2000);   // Non-blocking wait
    //     Console.WriteLine("Work finished");
    // }
}



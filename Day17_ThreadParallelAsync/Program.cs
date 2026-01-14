// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Threading;
using System.Threading.Tasks;//Parallel class

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

    // static public void Main(string[] args){
    //      //Thread with Parameter
    //    //Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
    //     //thread.Start("Hello from thread");

    //    //Thread without parameter
    //     // Thread worker = new Thread(DoWork);
    //     // worker.Start();
    //     // Console.WriteLine("Main thread continues...");
      
    //   //Basic parallel Loop
    //   //Parallel.For(start,end,body);
    // //   All iterations run inside the same process
    // //   But they may run on different threads
    // //   And those threads may execute on multiple CPU cores
    // //   Parallel.For(0,5,i => {
    // //     Console.WriteLine("Procesing item " + i);
    // //   });

    // // int[] numbers=new int[10];
    // // for(int i=0;i<numbers.Length;i++){
    // //     numbers[i] =i+1;
    // // }
    // //PART 1: NOT Thread-Safe (Race Condition)=>unpredictable
    // // int sum1=0;//sum1 is a shared variable
    // // Parallel.For(0,numbers.Length,i => {
    // //      sum1 += numbers[i];//not thread safe(for demonstrations)
    // // });
    // // Console.WriteLine(sum1);
    
    // //PART 2: Thread-Safe Using Thread-Local Variables=>always correct
    // //int sum2=0;
    // // Parallel.For(
    // //     0,
    // //     numbers.Length,
    // //     () => 0,    //initilisation localSum to 0 => //Thread-local initialization
    // //     (i,loopState,localSum) =>
    // //     {
    // //         return localSum + numbers[i];
    // //     },
    // //     localSum =>
    // //     {
    // //         Interlocked.Add(ref sum2,localSum);//Interlocked.Add ensures atomic operation | Safely merges results into sum2
    // //     }
    // // );
    // // Console.WriteLine(sum2);
    //}
  

    //async | await
    static async Task Main(string[] args){
        // Console.WriteLine("Main start");
        // await DoWorkAsync();
        // Console.WriteLine("Main end");
        
        Console.WriteLine("Start reading File...");
        string content=await File.ReadAllTextAsync("data.txt");
        Console.WriteLine("File content: " +content);

    }

    static async Task DoWorkAsync(){
        Console.WriteLine("Work started");
        await Task.Delay(2000);   // Non-blocking wait
        Console.WriteLine("Work finished");
    }
}



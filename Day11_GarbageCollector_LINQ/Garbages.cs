using System;
class Garbage{
    public static void xyz(){
        Console.WriteLine("Creating Object...");
        for(int i=0;i<5;i++){
            // Garbage g=new Garbage();
            MyClass g=new MyClass();
        }
        Console.WriteLine("Forcing Garbage collection...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Garbage collector completed");
    }
}
class MyClass{
    ~MyClass(){
        Console.WriteLine("Finalizer called,object created");
    }
}
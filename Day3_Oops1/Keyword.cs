class Keyword{
    //pass by reference
    public void Increase1(ref int x){
        x += x;
    }
    
    //pass by value
    public void Increase2(int x){
        x += x;
    }

    //out keyword
    public void Divide(int a, int b, out int quotient, out int remainder){
        quotient = a / b;
        remainder = a % b;
    }

     public void GetResult(int marks, out string grade){
        if (marks >= 60){
            grade = "Pass";
        }else{
            grade = "Fail";
        }
     }

     //in keyword
    public void Print(in int x){
        Console.WriteLine(x);
    }

    public void sum(int a,int b=10,params int[] numbers){
        int total=a+b;
        for(int i=0;i<numbers.Length;i++){
            total += numbers[i];
        }
        Console.WriteLine("Sum is: "+total);
    }
    
    //it gives error because params keyword should be the last parameter
    //  public void sum(int a,params int[] numbers,int b=10){
    //     int total=a+b;
    //     for(int i=0;i<numbers.Length;i++){
    //         total += numbers[i];
    //     }
    //     Console.WriteLine("Sum is: "+total);
    // }

    public void sum1(params int[] numbers){
        int total=0;
        for(int i=0;i<numbers.Length;i++){
            total += numbers[i];
        }
        Console.WriteLine("Sum is: "+total);
    }
}
class Calculator
{
    //static method, call by class name
    // public static int Add(int a, int b){
    //     return a+b;
    // }

    public int Add(int a, int b){
        return a+b;
    }

     public double Add(double a, int b){
        return a+b;
    }
    
    //Method Overloading
    public int Add(int a, int b,int c){
        return a+b+c;
    }

    public double Add(double a, double b){
        return a+b;
    }
}
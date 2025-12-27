using System;
//Generic
//T is a placeholder for a data type
//only reference types allowed->class,string,object,arraay etc
//Task2-Create a generic Repository class that can store and retrieve data of any reference type.
class Repository<T> where T:class{
    public T item;
}

//Tak-3
class Printer{
    public void print<T>(T data){
        Console.WriteLine(data);
    }
}

class Calculator{
    public T calculate<T>(T a,T b){
        //return a+b;//Operator '+' cannot be applied to operands of type 'T'
        return a;
        // T add = (dynamic)a + (dynamic)b;
        // return add;
    }
}

class Trade1{
    public int tradeId{ get; set; }
    public string stockSymbol{ get; set; }

    public void printData<T>(){
        Console.WriteLine("Trade ID: " + tradeId);
        Console.WriteLine("Stock Symbol: " + stockSymbol);
    }
}

class Account{
    public double balance{ get; set; }
}
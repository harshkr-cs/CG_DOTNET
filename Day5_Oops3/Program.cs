// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
class Program{

    public static void Main(string[] args){
         // Original struct
        // StockPrice sp1 = new StockPrice
        // {
        //     stockSymbol = "AAPL",
        //     price = 150.50
        // };
        // // Copy struct
        // StockPrice sp2 = sp1;

        // // Modify copied struct
        // sp2.price = 160.75;
        // Console.WriteLine("STRUCT (Value Type)");
        // Console.WriteLine("Original Price: " + sp1.price);
        // Console.WriteLine("Copied Price  : " + sp2.price);
        //  // struct is a value type
        // // Copy creates a new independent copy
        // // Changing sp2 does NOT affect sp1
        
        // //Original object
        // Trade tr = new Trade
        // {
        //     tradeId = 101,
        //     stockSymbol = "AAPL",
        //     quantity = 50
        // };
        // // Reference copy
        // Trade tr2 = tr;

        // // Modify via copied reference
        // tr2.quantity = 100;

        // Console.WriteLine("CLASS (Reference Type)");
        // Console.WriteLine("Original Quantity: " + tr.quantity);
        // Console.WriteLine("Copied Quantity  : " + tr2.quantity);

        // Portfolio p1=new Portfolio{name="Growth"};
        // Portfolio p2=new Portfolio{name="Growth123"};

        // // Comparison	Result	Why
        // // Equals()	true	Same name
        // //  ==	false	Different objects

        // Console.WriteLine("Portfolio p1 equals p2: " + p1.Equals(p2));//true->Equals() compares data, not memory location
        // Console.WriteLine("Portfolio p1 equals p2: " + (p1==p2));//false->Checks REFERENCE (Memory)->Checks whether both variables point to same object in memory

        // Console.WriteLine("HashCode p1: " + p1.GetHashCode());
        // Console.WriteLine("HashCode p2: " + p2.GetHashCode());
        

        // Trade et=new EquityTrade();
        // Console.WriteLine("et.getType(): " + et.GetType());//EquityTrade->return actual runtime type

        //Genrics example
        // Repository<Trade> repo=new Repository<Trade>();
        //M-1=>intilise object
        // repo.Data=new Trade{
        //     tradeId=101,
        //     stockSymbol="MSFT",
        //     quantity=200
        // };
        //M-2=>intilise object
        // repo.Data=new Trade();
        // repo.Data.tradeId=101;
        // repo.Data.stockSymbol="MSFT";
        // repo.Data.quantity=200;
        // Console.WriteLine("Trade from Generic Repository: " + repo.Data.tradeId + ", " + repo.Data.stockSymbol + ", " + repo.Data.quantity);

        // Calculator calc=new Calculator();
        // int intResult=calc.calculate(10,20);
        // Console.WriteLine("Integer is: " + intResult);

        // Trade1 t1=new Trade1{
        //     tradeId=201,
        //     stockSymbol="GOOGL"
        // };
        // t1.printData<int>();
        
        //Null Coalescing Operator (??)
    //     int? age = null;
    //     int result = age ?? 18;
    //     Console.WriteLine(result); // 18

    //     //Null Coalescing Assignment (??=)
    //     string name = null;
    //     name ??= "Guest";
    //     Console.WriteLine(name); // Guest
       
    //    //Null Propagation Operator (?.)
    //    User u = null;
    //    Console.WriteLine(u?.Name); // null (no exception)
    
    //Task1
    // Trade2 t2=new Trade2();
    // t2.tradeId=301;
    // t2.symbol="TSLA";
    // Console.WriteLine(t2.ToString());

    //Task2
    // Repository<Trade> repo=new Repository<Trade>();
    // repo.item=new Trade{
    //     tradeId=401,
    //     stockSymbol="NFLX",
    //     quantity=150
    // };
    // Console.WriteLine("Trade from Generic Repository: " + repo.item.tradeId + ", " + repo.item.stockSymbol + ", " + repo.item.quantity);

       //Task3
       Printer printer=new Printer();
       // printer.print<string>("Hello, Generics!");
       printer.print("Hello, Generics!");//Type inference
    }
}

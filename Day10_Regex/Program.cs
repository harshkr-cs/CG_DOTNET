// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.IO;
using LogProcessing;
class Program{
    public static void Main(string[] args){
        // int a=10;
        // int b=0;
        // //Attempted to divide by zero.
        // try{
        //     int res=a/b;
        // }catch(Exception e){
        //    Console.WriteLine("Error occurred: "+ e.Message);
        // }

        // try{
        //     //User input validation
        //     Console.Write("Enter withdrawl amount: ");
        //     decimal amount=decimal.Parse(Console.ReadLine());
        //     //Arithmetic operation
        //     int serviceCharge=100;
        //     int devisionCheck=serviceCharge/int.Parse("0");//Intentional error

        //     //File Access
        //     string data=File.ReadAllText("account.txt");
        //     //Business Logic
        //     BankAccount account=new BankAccount();
        //     account.Withdraw(amount);
        //     Console.WriteLine("Withdrawl Successful");
        // }catch(FormatException e){
        //     LogException(e);
        //     Console.WriteLine("Invalid Input Format.");
        // }catch(DivideByZeroException e){
        //     LogException(e);
        //     Console.WriteLine("Arithmetic error occured.");
        // }catch(FileNotFoundException e){
        //     LogException(e);
        //     Console.WriteLine("Required File not found");
        // }catch(InsufficientBalanceException e){
        //     LogException(e);
        //     Console.WriteLine(e.Message);
        // }catch(Exception e){
        //     LogException(e);
        //     Console.WriteLine("An unexpected error occured.");
        // }finally{
        //     Console.WriteLine("Transaction attemp completed.");
        // }

        // static void LogException(Exception e){
        //     File.AppendAllText(
        //         "error.log",
        //         DateTime.Now + " | " + e.GetType().Name + " | "+e.Message+Environment.NewLine
        //     );
        // }

        // FileStream file = null;
        // try{
        //     file = new FileStream("data.txt", FileMode.Open);
        //     // Perform file operations
        //     int data = file.ReadByte();
        // }
        // catch (FileNotFoundException ex){
        //     Console.WriteLine("File not found: " + ex.Message);
        // }
        // finally{
        //     if (file != null){
        //         file.Close(); // Ensures file is always closed
        //         Console.WriteLine("File stream closed in finally block.");
        //     }
        // }

        // try{
        //     // Simulate database operation
        //     throw new SqlException("Connection failed");
        // }
        // catch(SqlException ex){
        //     // Wrap low-level exception into higher-level exception
        //     throw new Exception("Database operation failed in Service Layer", ex);
        // }

    // try{
    //     try{
    //         File.ReadAllText("transaction.txt");
    //     }catch(IOException ioEx){
    //             throw new ApplicationException(
    //             "Unable to load transaction data",
    //             ioEx
    //         );
    //     }catch (Exception ex){
    //         Console.WriteLine("Message: " + ex.Message);
    //         Console.WriteLine("Root Cause: " + ex.InnerException.Message);
    //     }
    // }

        // BankAccounts acc=new BankAccounts(5000);
        // acc.Withdraw(-3000);

        //-----------------------------------------Regex Demo -------------------------------------------------------------------------
        // RegexDemo.RegexMatch();
        // LogParser log=new LogParser();
        //Task1-Validate Log Line Format
        // string[] logs = {
        //     "[INF] Application started",
        //     "[ERR] Null reference exception",
        //     "[DBG] Variable x = 10",
        //     "[WRN] Disk space low",
        //     "[FTL] System crash",
        //     "[TRC] Entering method",
        //     "[ABC] Invalid level",
        //     "INF Application started"
        // };
        // if(log.IsValidLine("[WRN] Low memory warning")){
        //     Console.WriteLine("Valid Log Lines");
        // }else{
        //    Console.WriteLine("Invalid Log Line");
        // }
        //Task2- //Task-2Split Log Line delimeter(<***>, <====>, <^*>) 
        // string logs = "[[INF] User login<*>Session created<====>Access granted";
        // string[] parts=log.SplitLogLine(logs);
        // foreach(string str in parts){
        //     Console.WriteLine(str + " ");
        // }

        //Task3-Count Quoted Password Occurrences 
        // string input =
        //     @"User said ""password123 is weak""
        //     Admin noted ""PASSWORD456 expired""
        //     No issue found";
        // int logs=log.CountQuotedPasswords(input);
        // Console.WriteLine(logs);

        //Task4-Remove text matching the pattern: end-of-line<number> 
        // string text = "Transaction completed successfully end-of-line456";
        // string res=log.RemoveEndOfLineText(text);
        // Console.WriteLine(res);

        //Task5
        // string[] lines ={
        //     "User entered password123 during login",
        //     "System startup completed",
        //     "Admin reset passwordABC",
        //     "Backup process finished"
        // };
        // string[] weakPasswordLines = log.ListLinesWithPasswords(lines);
        //  foreach (var line in weakPasswordLines){
        //     Console.WriteLine(line);
        // }
        
        LogParser L=new LogParser();
        //Task9.5-Ignore Masked or Redacted Secrets 
        // string[] tests ={
        //     "password=abc123",
        //     "passwordTemp456",
        //     "password=****",
        //     "password=XXXXX",
        //     "password=####"
        // };
        // L.IgnoredMaked(tests);
       // Task9.9- Validate ISO-8601 Timestamp Strictly
        string[] tests =
        {
            "2025-03-21T14:22:19Z",
            "2025-13-40T99:99:99Z",
            "2025-03-21T14:22:19.123Z",
            "2025-03-21T14:22:19+05:30"
        };
        L.ValidateISO8601Timestamp(tests);

    }
}
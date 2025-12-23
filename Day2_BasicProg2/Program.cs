// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using HelloWorldApp;   //Import namespace

class HelloWorld{
    public static void Main(string[] args){
        //1)Print welcome message on 
        //Console.WriteLine("Hello, World!");// This line prints Hello, World! to the console
        // string s=Console.ReadLine(); // This line waits for user input before closing the console
        // Console.WriteLine(s);

        // Console.Write("Harsh Kumar \n");//print with new line
        // Console.Write("Capgemini");//print without new line
      
        // Object creation for Employee class
        // Employee emp = new Employee();
        // emp.AcceptDetails();
        // emp.DisplayDetails();
        
        // Object creation for Employee class
        // Calculator calc = new Calculator();

        // Console.WriteLine("Enter first number:");
        // int num1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter second number:");
        // int num2 = Convert.ToInt32(Console.ReadLine());

        // calc.Add(num1, num2);

        //(2)write a program to read a number from user and display it on console
        // Console.ReadLine() → reads input as string
        // Convert.ToInt32() → converts string to integer
        // Console.WriteLine() → prints output
        //int number=0 ->declares an integer variable named number and initializes it to 0 so that no error occurs while using it later.
        //int number=0;
        // Console.WriteLine("Enter a number:");
        // int number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("You entered: " + number);

        //(3)write a program to read a floating point number from user and display it on console
        // float flt=0.0f;
        // Console.WriteLine("Enter a floating point number:");    
        // flt = Convert.ToSingle(Console.ReadLine());
        // Console.WriteLine("You entered: " + flt);

        //(4)write a program to read a string from user and display it on console
        // string str=string.Empty;
        // Console.WriteLine("Enter string:");    
        // str= Console.ReadLine();
        // Console.WriteLine("You entered: " + str);

        //(5)write a program to find area of circle
        // const float PI = 3.14f;  
        // float radius = 0.0f;
        // Console.WriteLine("Enter radius of circle:");    
        // radius = Convert.ToSingle(Console.ReadLine());   
        // float area = PI * radius * radius;
        // Console.WriteLine("Area of circle: " + area);

        //(6)write a program to perform basic arithmetic operations using methods
        // int num1=0;
        // int num2=0;
        // Console.WriteLine("Enter first number:");
        // num1=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number:");
        // num2=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Addition is "+ (num1 + num2));
        // Console.WriteLine("Subtraction is "+ (num1 - num2));
        // Console.WriteLine("Multiplication is "+ (num1 * num2));
        // if(num2 != 0){
        //     Console.WriteLine("Division is "+ (num1 / num2));
        //     Console.WriteLine("Modulus is "+ (num1 % num2));
        // }
        // else{
        //     Console.WriteLine("Division and Modulus by zero is not allowed.");
        // }

        //(7)write a programme to find number is even or odd
        //int num=0;
        // Console.WriteLine("Enter a number:");
        //num=Convert.ToInt32(Console.ReadLine());
        // if(num % 2 == 0){
        //     Console.WriteLine("Number is even.");
        // }
        // else{
        //     Console.WriteLine("Number is odd.");
        // }

        //(8)write a programme to find largest among two numbers
        // Console.WriteLine("Enter first number:");
        // int num1=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number:");
        // int num2=Convert.ToInt32(Console.ReadLine());
        // if(num1>num2){
        //     Console.WriteLine(num1 + " is greater than " + num2);
        // }
        // else{
        //     Console.WriteLine(num2 + " is greater than " + num1);
        // }

        //(9)write a prograame to find the given num is positive,negative or zero
        //int num=0;
        // Console.WriteLine("Enter a number:");        
        //num=Convert.ToInt32(Console.ReadLine());
        // if(num>0){
        //     Console.WriteLine("Number is positive.");
        // }
        // else if(num<0){  
        //     Console.WriteLine("Number is negative.");
        // }
        // else{   
        //     Console.WriteLine("Number is zero.");
        // }

        //(10)write a programme to find largest among three numbers using nested if
        //int num1=0;
        //int num2=0;
        //int num3=0;
        // Console.WriteLine("Enter first number:");
        // int num1=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number:");
        // int num2=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter third number:");
        // int num3=Convert.ToInt32(Console.ReadLine()); 

        // if(num1>=num2){
        //     if(num1>=num3){                      
        //         Console.WriteLine(num1 + " is the largest number.");
        //     }
        //     else{
        //         Console.WriteLine(num3 + " is the largest number.");
        //     }

        // }
        // else{
        //     if(num2>=num3){
        //         Console.WriteLine(num2 + " is the largest number.");                 
        //     }
        //     else{
        //         Console.WriteLine(num3 + " is the largest number.");
        //     }
        // }

        //write a proggrame to check whether the character is vowel or consonant
        // char ch='\0';
        // Console.WriteLine("Enter a character:");
        // ch=Convert.ToChar(Console.ReadLine());
        // switch(ch){
        //     case 'a':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'e':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'i':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'o':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'u':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'A':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'E':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'I':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'O':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     case 'U':
        //         Console.WriteLine(ch + " is a vowel.");
        //         break;
        //     default:
        //         Console.WriteLine(ch + " is a consonant.");
        //         break;

        // }
        //find all thing for string
        // string str=string.Empty;
        // Console.WriteLine("Enter a string:");
        // str= Console.ReadLine();//read string from input
        // Console.WriteLine("Uppercase String:" + str.ToUpper());//convert to uppercase
        // // Console.WriteLine("Lowercase String:" + str.ToLower());//convert to lowercase
        // string strL=str.ToLower();
        // Console.WriteLine("Lowercase String:" + strL);
        // Console.WriteLine("Original String Length:" + str.Length);//find length of string

        //swap two number without uisng third variable
        // int num1=0;
        // int num2=0;
        // Console.WriteLine("Enter first number:");
        // num1=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number:");
        // num2=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Before Swapping: num1 = " + num1 + ", num2 = " + num2);
        // //Main Logic to swap two numbers without using third variable
        // num1=num1+num2;
        // num2=num1-num2;
        // num1=num1-num2;
        // Console.WriteLine("After Swapping: num1 = " + num1 + ", num2 = " + num2);
        // //swap using bitwise XOR operator
        // num1=num1^num2;
        // num2=num1^num2;
        // num1=num1^num2;
        // Console.WriteLine("After Swapping using Bitwise XOR: num1 = " + num1 + ", num2 = " + num2);

    
      //---------------------------------------LOOP--------------------------------------------------------------------------------   
      // int n=0;
      // Console.WriteLine("Enter a number:");
      // n=Convert.ToInt32(Console.ReadLine());
      //while loop
      // int count=0;
      // //print first n natural number
      // while(count<n){
      //    count++;
      //    Console.WriteLine(count);
      //    
      // } 
      
      //print first n natural number in reverse order
      // int count=0;
      // while(n>count){
      //   Console.WriteLine(n);
      //   n--;
      // }    

     //do while loop
      // int count=0;
      // do{
      //   count++;
      //   Console.WriteLine(count);
      // }while(count<n);

       //for loop
       //Multiple of 20 to 30
      //  for(int num=20;num<=30;num++){
      //       for(int i=1;i<=10;i++){
      //         Console.WriteLine(num + " x " + i + " = " + (num*i));
      //       }
      //       Console.WriteLine("\n");//this is used for change line after each table
      //  }
       
       //for each loop
      //  int[] numbers = { 10, 20, 30, 40 };
      //   foreach (int num in numbers){
      //     Console.WriteLine(num);
      //   }
      
      //Game simulation using loop and continue statement
      // Console.WriteLine("GAME BEGINS");
      // for(int i=1;i<=10;i++){
      //   if(i==4){
      //     Console.WriteLine("E"+ i  + " is invisible skipping e "+ i);
      //     continue;
      //   }
      //   Console.WriteLine("Player killed e"+ i);
      // }
      // Console.WriteLine("GAME END");

      //Finance Control System
      // Finance finance = new Finance();
      // finance.ShowFinanceDetails();

      Debit debit = new Debit();
      Credit credit = new Credit();
      
      do
        {
          Console.WriteLine("\n===== Finance Management System =====");
          Console.WriteLine("1. Debit Operations");
          Console.WriteLine("2. Credit Operations");
          Console.WriteLine("3. Exit");
          Console.Write("Enter your choice: ");
          int choice = Convert.ToInt32(Console.ReadLine());
          switch (choice)
            {
              case 1:
                Console.WriteLine("\n--- Debit Operations ---");
                Console.WriteLine("1. ATM Withdrawal Limit");
                Console.WriteLine("2. EMI Evaluation");
                Console.WriteLine("3. Daily Spending Calculator");
                Console.WriteLine("4. Minimum Balance Check");
                Console.Write("Choose option: ");
                int d = int.Parse(Console.ReadLine());

                switch (d)
                  {
                    case 1: debit.AtmWithdrawalLimit(); break;
                    case 2: debit.EmiEvaluation(); break;
                    case 3: debit.DailySpending(); break;
                    case 4: debit.MinimumBalanceCheck(); break;
                    default: Console.WriteLine("Invalid option."); break;
                  }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Credit Operations ---");
                        Console.WriteLine("1. Net Salary Calculation");
                        Console.WriteLine("2. Fixed Deposit Maturity");
                        Console.WriteLine("3. Reward Points");
                        Console.WriteLine("4. Bonus Eligibility");
                        Console.Write("Choose option: ");
                        int c = int.Parse(Console.ReadLine());

                        switch (c)
                        {
                            case 1: credit.NetSalaryCalculation(); break;
                            case 2: credit.FixedDepositMaturity(); break;
                            case 3: credit.RewardPoints(); break;
                            case 4: credit.BonusEligibility(); break;
                            default: Console.WriteLine("Invalid option."); break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting program. Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid main menu choice.");
                        break;
                }

            }while(choice != 3);
        
       

    }
}
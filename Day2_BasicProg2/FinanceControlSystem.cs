using System;

class Finance{
    public void ShowFinanceDetails(){
        Console.WriteLine("Finance Details: ");
        Console.WriteLine("1.Check Loan Eligibility");
        Console.WriteLine("2.Calculate Tax");
        Console.WriteLine("3.Enter Transactions");
        Console.WriteLine("4.Exit");
        Console.WriteLine("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice){
            case 1:
                Console.WriteLine("Checking Loan Eligibility...");
                int age=Convert.ToInt32(Console.ReadLine());
                float MonthlyIncome=Convert.ToSingle(Console.ReadLine());
                if(age>=21 && MonthlyIncome>=30000){
                    Console.WriteLine("Eligible for Loan");
                }
                else{
                    Console.WriteLine("Not Eligible for Loan");
                }
                break;
            case 2:
                Console.WriteLine("Calculating Tax...");
                int annualIncome=Convert.ToInt32(Console.ReadLine());
                if(annualIncome<=250000){
                    Console.WriteLine("Tax is: " + 0);
                }
                else if(annualIncome>250000 && annualIncome<=500000){
                    Console.WriteLine("Tax is: " + (annualIncome*0.05));
                }
                else if(annualIncome>500000 && annualIncome<=1000000){
                    Console.WriteLine("Tax is: " + (annualIncome*0.2));
                }
                else{
                    Console.WriteLine("Tax is: " + (annualIncome*0.3));
                }
                break;
            case 3:
                Console.WriteLine("Enter Transactions...");
                int i=0;
                float totalAmount=0;
                while(i<5){
                    Console.WriteLine("Enter transaction amount:");
                    float amount=Convert.ToSingle(Console.ReadLine());
                    if(amount<0){
                        Console.WriteLine("Invalid amount. Please enter a positive value.");
                        continue;
                    }
                    totalAmount += amount;
                    Console.WriteLine("Transaction of total amount is " + totalAmount);
                    i++;
                }
                break;
            case 4:
                Console.WriteLine("Exit From Finance Control System.");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}
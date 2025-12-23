using System;

namespace HelloWorldApp
{
    class Credit{
       public void atmWithdrwal(){
           Console.WriteLine("Enter Withdraw Amount: ");
           int wAmount=Convert.ToInt32(Console.ReadLine());
            if(wAmount<=40000){
                Console.WriteLine("Withdrawal permitted within daily limit. " + wAmount);
            }
            else{
                Console.WriteLine("Daily ATM withdrawal limit exceeded.");
           }
       }

       public void EBE(){
           Console.WriteLine("Enter Monthly Income: ");
           float income=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("EMI Amount: ");
           int emi=Convert.ToInt32(Console.ReadLine());
           float managableEMI=income*0.4f;
           if(EMI<=managableEMI){
               Console.WriteLine("EMI is financially manageable.");
           }
           else{
               Console.WriteLine("EMI exceeds safe income limit.");
           }
       }

       public void trasactionDailySpendingCalculator(){
            Console.WriteLine("Enter Number Of Transaction Today: ");
            int n=Convert.ToInt32(Console.ReadLine());
            float totalSpending=0;
            for(int i=1;i<=n;i++){
                Console.WriteLine("Enter Transaction Amount: ");
                float tAmount=Convert.ToSingle(Console.ReadLine());
                totalSpending += tAmount;
            }
            Console.WriteLine("Total Spending Today: " + totalSpending);
       }

       public void minimumBalancedCheck(){
            Console.WriteLine("Enter Current Account Balance: ");
            float balance=Convert.ToSingle(Console.ReadLine());
            if(balance>=2000){
                Console.WriteLine("Minimum balance requirement satisfied.");
            }
            else{
                Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
            }
       }
    }

    class Debit{
         public void NetSalaryCalculator(){
            Console.WriteLine("Enter Gross Salary: ");
            float grossSalary=Convert.ToSingle(Console.ReadLine());
            float netSalary=grossSalary*0.1f; // Assuming 10% deductions
            Console.WriteLine("Net Salary is: " + netSalary);
            
         }

         public void FDMC(){
            float p=0.0f;
            float r=0.0f;
            int t=0;
            Console.WriteLine("Enter Principal Amount: ");
            p=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest: ");
            r=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Time in Years: ");
            t=Convert.ToInt32(Console.ReadLine());
            float SI=(p*r*t)/100;
            float maturityAmount=p+SI;
            Console.WriteLine("Fixed Deposit maturity amount: " + maturityAmount);
         }

         public void rewardPointsCalculator(){
            Console.WriteLine("Enter Total Spend Amount: ");
            float spendAmount=Convert.ToSingle(Console.ReadLine());
            int rewardPoints=(int)(spendAmount/100); 
            Console.WriteLine("Reward points earned: " + rewardPoints);
         }

         public void bonusEligibleCheck(){
            float annualSalary=0.0f;
            Console.WriteLine("Enter Annual Salary: ");
            annualSalary=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Years of Service: ");
            int yearsOfService=Convert.ToInt32(Console.ReadLine());
            if(yearsOfService>=3 && annualSalary>=500000){
                Console.WriteLine("Employee is eligible for bonus.");
            }
            else{
                Console.WriteLine("Employee is not eligible for bonus.");
            }
         }
    }
        
 
}
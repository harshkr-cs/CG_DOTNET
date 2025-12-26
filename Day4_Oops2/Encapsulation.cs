using System;
class Encapsulation{
    private double balance;

     //directly used setter method
    public void Deposit(double amount){
        if (amount > 0)
            balance += amount;
    }
    //directly used getter method
    public double GetBalance(){
        return balance;
    }
    
    //getter and setter using properties
    // public double Balance{
    //     get { return balance; }
    //     private set { balance = value; }
    // }

    // public void Deposit(double amount){
    //     if (amount > 0)
    //         Balance += amount;   // allowed (inside class)
    // }

    // public bool Withdraw(double amount){
    //     if (amount > 0 && amount <= Balance){
    //         Balance -= amount;
    //         return true;
    //     }
    //     return false;
    // }
}

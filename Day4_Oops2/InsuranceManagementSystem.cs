using System;

sealed class SecurityPoliciy{
    private string pw="admin@123";
    // public void DisplayPolicy(){
    //     Console.WriteLine("The user get authenticateed");
    // }
    public SecurityPoliciy(string pw){
        if(this.pw == pw){
            Console.WriteLine("The user get authenticated");
        }
        else{
            Console.WriteLine("Authentication Failed");
        }
    }

}



abstract class InsurancePolicy
{
    // Init-only property for Policy Number
    public int PolicyNumber { get; init; }

    // Private backing field for premium
    private double premium;

    // Validated Premium Property
    public double Premium
    {
        get{
            return premium;
        }
        set{
            if (value > 0)
            {
                premium = value;
            }
            else
            {
                Console.WriteLine("Premium must be greater than zero.");
            }
        }
    }

    // Policy Holder Name Property
    public string PolicyHolderName { get; set; }

    public virtual void CalculatePremium(){
        Console.WriteLine("Calculating base premium...");
    }
     
    public void DisplayInfo(){
        Console.WriteLine("Policy Number: " + PolicyNumber);
        Console.WriteLine("Policy Holder Name: " + PolicyHolderName);
        Console.WriteLine("Premium: " + Premium);
    }
}

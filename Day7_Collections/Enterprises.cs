using System;
class Enterprises{
    public static void Task1(){
        Console.WriteLine("Enter Number of Product: ");
        int n=int.Parse(Console.ReadLine());
        int[] product=new int[n];
        double sum=0;
        for(int i=0;i<n;i++){
            int p=int.Parse(Console.ReadLine());
            if(p>0){
                product[i]=p;
                sum += (double)p;
            }
        }
        //sort the array
        Array.Sort(product);
        double Avg=sum/n;
        for(int i=0;i<n;i++){
            if(product[i]<Avg){
                product[i]=0;
            }
        }
        Array.Resize(ref product,n+5);
        for(int i=n;i<product.Length;i++){
            product[i]=(int)Avg;
        }
        for(int i=0;i<product.Length;i++){
            Console.Write(product[i] + " ");
        }

    }

    public static void Task2(){
    Console.WriteLine("Enter number of branches:");
    int branches = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter number of months:");
    int months = int.Parse(Console.ReadLine());

    int[,] sales = new int[branches, months];
    int[] branchTotals=new int[branches];

    // Accept sales data
    for (int i = 0; i < branches; i++){
        Console.WriteLine("Enter sales for Branch "+(i+1) + " ");
        for (int j = 0; j < months; j++){
            Console.Write($"Month {j + 1}: ");
            sales[i, j] = int.Parse(Console.ReadLine());
        }
    }

    int highestSale = int.MinValue;

    // Calculate total per branch
    for (int i = 0; i < branches; i++){
        int branchTotal = 0;

        for (int j = 0; j < months; j++){
            branchTotal += sales[i, j];

            if (sales[i, j] > highestSale)
                highestSale = sales[i, j];
        }
        
        branchTotals[i]=branchTotal;
        
    }
    for(int i=0;i<branches;i++){
       Console.WriteLine("Total sales of Branch "+ (i+1) + ":" +branchTotals[i]);
    }
    Console.WriteLine("Highest monthly sale across all branches: " + highestSale);
}
     public static void Task3(int[,] sales, double productAverage){
            int branches = sales.GetLength(0);
            int months = sales.GetLength(1);

 
            int[][] filteredSales = new int[branches][];

            for (int i = 0; i < branches; i++){
        
                int count = 0;
                for (int j = 0; j < months; j++){
                    if (sales[i, j] >= productAverage)
                    count++;
                }
            
        
            filteredSales[i] = new int[count];

            int index = 0;
            for (int j = 0; j < months; j++){
                if (sales[i, j] >= productAverage){
                filteredSales[i][index++] = sales[i, j];
            }
           }
        }

    
        Console.WriteLine("\nPerformance Based Sales (Jagged Array):");
        for (int i = 0; i < filteredSales.Length; i++){
            Console.Write($"Branch {i + 1}: ");
            foreach (int value in filteredSales[i]){
            Console.Write(value + " ");
        }
            Console.WriteLine();
        }
    }

    public static void Task4(){
        Console.WriteLine("Enter number of customer Trsanctions: ");
        int n=int.Parse(Console.ReadLine());
        List<int> id=new List<int>();
        Console.WriteLine("Enter Id: ");
        for(int i=0;i<n;i++){
            id.Add(int.Parse(Console.ReadLine()));
        }
        // Remove duplicates using HashSet
        HashSet<int> ht=new HashSet<int>();
        foreach(int ele in id){
            ht.Add(ele);
        }
        //convert back to list
        // List<int> cleanedId=new List<int>();
        // foreach(int ele in ht){
        //     cleanId.Add(ele);
        // }
        List<int> cleanedId = new List<int>(ht);
        foreach(int ele in cleanedId){
            Console.WriteLine(ele);
        }
        int duplicateId=id.Count-ht.Count;
        Console.WriteLine("Duplicate Id removed is "+ duplicateId);
    }

}
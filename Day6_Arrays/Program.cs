// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections;
using System.Collections.Generic;
class Program{
    static void Main(string[] args){
        
        //1-D Array
        // int[] marks = { 80, 85, 90, 95 };//Array With values initialized
        // Console.WriteLine("Marks:");
        // foreach(int mark in marks){
        //     Console.WriteLine(mark);
        // }
        // int total = 0;
        // for(int i=0;i<marks.Length;i++){
        //     total += marks[i];
        // }
        // double avg= (double)total / marks.Length;
        // Console.WriteLine("Average Marks: " + avg);

        // int[] nums=new int[5];//Fixed size Array
        // nums[0] = 10;
        // nums[1] = 20;
        // nums[2] = 30;
        // nums[3] = 40;
        // nums[4] = 50;
        // Console.WriteLine("Array elements:");
        // //iterating using for loop
        // for(int i=0;i<nums.Length;i++){
        //     Console.Write(nums[i] + " ");
        // }
        // Console.WriteLine();
        // //iterating using foreach
        // foreach (int num in nums){
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine();

        //2-D Array
    //    int[,] matrix = {
    //         {1, 2, 3},
    //         {4, 5, 6}
    //    };
    //     Console.WriteLine("2-D Array elements:");
    //     for (int i = 0; i < matrix.GetLength(0); i++){ // rows
    //         for (int j = 0; j < matrix.GetLength(1); j++){// columns
    //             Console.Write(matrix[i, j] + " ");
    //         }
    //         Console.WriteLine();
    //     }

        //jagged Array
        // int[][] jagged = new int[3][];
        // jagged[0] = new int[] { 1, 2 };    
        // jagged[1] = new int[] { 3, 4, 5 };
        // jagged[2] = new int[] { 6, 7, 8, 9 };
        // for (int i = 0; i < jagged.Length; i++){
        //     for (int j = 0; j < jagged[i].Length; j++){
        //         Console.Write(jagged[i][j] + " ");
        //     }
        //     Console.WriteLine();
        // }
        
        //Array Methods
        //sort method->it sorts the elements in ascending order
        // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        // Array.Sort(cars);
        // Console.WriteLine("Sorted Cars:");
        // foreach (string car in cars){
        //     Console.WriteLine(car);
        // }

        //clear method
        // int[] data = { 10, 20, 30, 40, 50 };

        // Array.Clear(data, 2, 2);   // Clears 2 elements starting from index 2

        // Console.WriteLine("Array after Clear:");
        // foreach (int item in data){
        //     Console.Write(item + " ");
        // }
        
        //copy method
        // int[] src= { 1, 2, 3};
        // int[] dest=new int[5];
        // Array.Copy(src,dest, 1); // Copies the first length elements from src to dest, starting at index 0 in both arrays.
        // Array.Copy(src,dest,2); //copy 2 elements from src to dest starting at index 0
        // Array.Copy(src,1,dest,2,2); //copy 2 elements from src starting at index 1 to dest starting at index 2

        //Resize method
        // int[] numbers = { 1, 2, 3 };
        // Array.Resize(ref numbers, 5); // Resize to hold 5 elements->ref allows modification of original array
        // //Array.Resize(numbers, 5);//witjout ref ->Compile-time error
        // numbers[3] = 4;
        // numbers[4] = 5;
        // Array.Resize(ref numbers, 1); // Resize  to 1 elements
        // Console.WriteLine("Resized Array elements:");
        // foreach (int num in numbers){
        //     Console.Write(num + " ");
        // }
        // Element change → no ref
        //Reference change → ref required

        //indexof method-
        // int[] values = { 10, 20, 30, 40, 50, 30 };
        // int index = Array.FirstIndexOf(values, 30); //returns first index of 30
        // Console.WriteLine("Index of 30: " + index);
        // int lastIndex = Array.LastIndexOf(values, 30); //returns last index of 30
        // Console.WriteLine("Last Index of 30: " + lastIndex); 

        //Exists method->Array.Exists(arr,condition)
        // int[] values = { 10, 20, 30, 40, 50 };
        // bool exists = Array.Exists(values, element => element == 30);   //checks if 30 exists
        // Console.WriteLine("Does 30 exist in array? " + exists);
        
        //Generic collections
        //List
        // List<int> numbers = new List<int>();
        // numbers.Add(10);
        // numbers.Add(20);
        // numbers.Add(30);
        // Console.WriteLine("List elements:");
        // // foreach(int num in numbers){
        // //     Console.WriteLine(num);
        // // }
        // for(int i=0;i<numbers.Count;i++){
        //     Console.WriteLine(numbers[i]);
        // }

        //Hashtable->store key-value pairs using hashing
        // Hashtable ht = new Hashtable();
        // ht.Add(1,"Admin");
        // ht.Add(2,"User");
        // ht.Add(3,"Guest");
        // Console.WriteLine("Hashtable elements 1:"+ht[1]);
        // Console.WriteLine("Hashtable elements 2:"+ht[2]);
        // Console.WriteLine("Hashtable elements 3:"+ht[3]);
       //Generic->Gneric are in System.Collections.Generic
       //Non-generic->are in System.Collections

       
        //Dictionary->key-value pairs
        // Dictionary<int, string> dict = new Dictionary<int, string>();
        // dict.Add(1, "Apple");
        // dict.Add(2, "Banana");
        // dict.Add(3, "Cherry");
        // Console.WriteLine("Dictionary elements:");
        // foreach (KeyValuePair<int, string> pair in dict){
        //     Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
        // }

       //stack->LIFO
        // Stack<int> st= new Stack<int>();
        // st.Push(10);
        // st.Push(20);
        // st.Push(30);
        // Console.WriteLine("Stack elements:");
        // while(st.Count>0){
        //     Console.Write(st.Peek() + " ");
        //     st.Pop();
        // }

        //Queue->FIFO
        // Queue<string> queue = new Queue<string>();
        // queue.Enqueue("First");
        // queue.Enqueue("Second");
        // queue.Enqueue("Third");
        // Console.WriteLine("Queue elements:");
        // while (queue.Count > 0){
        //     Console.Write(queue.Peek() + " ");
        //     queue.Dequeue();
        // }

        //Set->duplicate values are not allowed
        // HashSet<int> set = new HashSet<int>();
        // set.Add(10);
        // set.Add(20);
        // set.Add(30);
        // set.Add(20); // Duplicate, will be ignored
        // Console.WriteLine("HashSet elements:");
        // foreach (int item in set){
        //     Console.Write(item + " ");
        // }
        // Console.WriteLine();

        //SortedList->sorted key-value pairs
        // SortedList<string, string> sortedList = new SortedList<string, string>();
        // sortedList.Add("b", "B");
        // sortedList.Add("c", "C");
        // sortedList.Add("a", "A");
        // Console.WriteLine("SortedList elements:");
        // foreach (KeyValuePair<string, string> pair in sortedList){
        //     Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
        // }

        //Using TryGetValue(safe Access)
        // Dictionary<int, string> emp = new Dictionary<int, string>();
        // emp.Add(1, "Alice");
        // emp.Add(2, "Bob");
        // emp.Add(3, "Charlie");
        // if(emp.TryGetValue(2, out string name)){
        //     Console.WriteLine("Employee with ID 2: " + name);
        // }else{
        //     Console.WriteLine("Employee with ID 2 not found.");
        // }

        //Task1:Find the frequency of elements in an array using a Dictionary
        // int[] arr = {1, 2, 3, 2, 1, 4, 2};
        // Dictionary<int,int> freq=new Dictionary<int,int>();
        // foreach(int num in arr){
        //     if(freq.ContainsKey(num)){
        //         freq[num]++;
        //     }else{
        //         freq[num]=1;
        //     }
        // }

        // Console.WriteLine("Element Frequencies:");
        // foreach(KeyValuePair<int,int> pair in freq){
        //     Console.WriteLine("Element: " + pair.Key + "-> Frequency: " + pair.Value);
        // }

        // //Task2:Merge two sorted arrays into a single sorted array.
        // int[] arr1 = {1, 3, 5};//sorted array
        // int[] arr2 = {2, 4, 6};//sorted array
        // int n1=arr1.Length;
        // int n2=arr2.Length;
        // int n=n1+n2;
        // int[] merged=new int[n];
        // int i=0,j=0,k=0;
        // //merging logic
        // while(i<n1 && j<n2){
        //     if(arr1[i]<arr2[j]){
        //         merged[k++]=arr1[i++];
        //     }else{
        //         merged[k++]=arr2[j++];
        //     }
        // }
        // //copy remaining elements from arr1
        // while(i<n1){
        //     merged[k++]=arr1[i++];
        // }
        // //copy remaining elements from arr2
        // while(j<n2){
        //     merged[k++]=arr2[j++];
        // }
        // //print merged array
        // Console.WriteLine("Merged Sorted Array:");
        // int x=0;
        // while(x<n){
        //     Console.Write(merged[x]+" ");
        //     x++;
        // }

        //flip key logical problem
        // FlipKeyLogicalProblem flipKey = new FlipKeyLogicalProblem();
        // string result = flipKey.CleanseAndInvert("Magic");
        // Console.WriteLine("Result: " + result);

        // PayRollService service = new PayRollService();

        // while (true){
        //     Console.WriteLine("\nPayroll System:");
        //     Console.WriteLine("1. Register Employee");
        //     Console.WriteLine("2. Get Overtime Week Counts");
        //     Console.WriteLine("3. Calculate Average Monthly Pay");
        //     Console.WriteLine("4. Exit");
        //     Console.Write("Enter your choice: ");

        //     int choice = Convert.ToInt32(Console.ReadLine());

        //     switch (choice)
        //     {
        //         case 1:
        //             Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
        //             int type = Convert.ToInt32(Console.ReadLine());

        //             Console.Write("Enter Employee Name: ");
        //             string name = Console.ReadLine();

        //             double[] hours = new double[4];
        //             Console.WriteLine("Enter weekly hours (Week 1 to 4):");
        //             for (int i = 0; i < 4; i++)
        //                 hours[i] = Convert.ToDouble(Console.ReadLine());

        //             Console.Write("Enter Hourly Rate: ");
        //             double rate = Convert.ToDouble(Console.ReadLine());

        //             if (type == 1)
        //             {
        //                 Console.Write("Enter Monthly Bonus: ");
        //                 double bonus = Convert.ToDouble(Console.ReadLine());

        //                 service.RegisterEmployee(new FullTimeEmployee
        //                 {
        //                     EmployeeName = name,
        //                     WeeklyHours = hours,
        //                     HourlyRate = rate,
        //                     MonthlyBonus = bonus
        //                 });
        //             }
        //             else
        //             {
        //                 service.RegisterEmployee(new ContractEmployee
        //                 {
        //                     EmployeeName = name,
        //                     WeeklyHours = hours,
        //                     HourlyRate = rate
        //                 });
        //             }

        //             Console.WriteLine("Employee registered successfully");
        //             break;

        //         case 2:
        //             Console.Write("Enter hours threshold: ");
        //             double threshold = Convert.ToDouble(Console.ReadLine());

        //             var result = service.GetOvertimeWeekCounts(
        //                 PayRollService.PayrollBoard, threshold);

        //             if (result.Count == 0)
        //             {
        //                 Console.WriteLine("No overtime recorded this month");
        //             }
        //             else
        //             {
        //                 foreach (var item in result)
        //                 {
        //                     Console.WriteLine(item.Key + " - " + item.Value);
        //                 }
        //             }
        //             break;

        //         case 3:
        //             double avg = service.CalculateAverageMonthlyPay();
        //             Console.WriteLine("Overall average monthly pay: " + avg);
        //             break;

        //         case 4:
        //             Console.WriteLine("Logging off — Payroll processed successfully!");
        //             return; // clean exit

        //         default:
        //             Console.WriteLine("Invalid choice. Please try again.");
        //             break;
        //     }
        // }

        //Medisure Clinic
        while(true){
            Console.WriteLine("----------------------------------MediSure Clinic Billing---------------------");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            int choice=0;
            choice=Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    PatientBill.CreateBill();
                    break;
                case 2:
                    PatientBill.ViewBill();
                    break;
                case 3:
                   PatientBill.ClearBill();
                   break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.!");
                    return; // clean exit
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }








    }
}
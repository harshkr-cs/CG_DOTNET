// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using DialingCodesApp;
class Programme{
    public static Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        chocolate.TotalPrice = chocolate.Quantity * chocolate.PricePerUnit;

        if (chocolate.Flavour == "Dark"){
            chocolate.DiscountedPrice =chocolate.TotalPrice - (0.18 * chocolate.TotalPrice);
        }
        else if (chocolate.Flavour == "Milk"){
            chocolate.DiscountedPrice =
                chocolate.TotalPrice - (0.12 * chocolate.TotalPrice);
        }
        else{ // White
            chocolate.DiscountedPrice =
                chocolate.TotalPrice - (0.06 * chocolate.TotalPrice);
        }

        return chocolate;
    }


    public static void Main(string[] args){

        //Case Study: Sugar Bliss Bakery
        // Chocolate chocolate = new Chocolate();

        // Console.WriteLine("Enter the flavour (Dark/Milk/White): ");
        // chocolate.Flavour = Console.ReadLine();

        // if (!chocolate.ValidateChocolateFlavour(chocolate.Flavour)){
        //     Console.WriteLine("Invalid chocolate flavour");
        //     return;
        // }

        // Console.WriteLine("Enter Quantity: ");
        // chocolate.Quantity = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter the price per unit: ");
        // chocolate.PricePerUnit = Convert.ToInt32(Console.ReadLine());

        // Programme.CalculateDiscountedPrice(chocolate);

        // Console.WriteLine("\n--- Chocolate Bill ---");
        // Console.WriteLine("Flavour: " + chocolate.Flavour);
        // Console.WriteLine("Quantity: " + chocolate.Quantity);
        // Console.WriteLine("Price Per Unit: " + chocolate.PricePerUnit);
        // Console.WriteLine("Total Price: " + chocolate.TotalPrice);
        // Console.WriteLine("Discounted Price: " + chocolate.DiscountedPrice);

        //dialingcode->collections dictionary
         // Task 1: Create Empty Dictionary
        Dictionary<int, string> emptyDict = DialingCodes.GetEmptyDictionary();
        Console.WriteLine("Task 1: Empty Dictionary");
        PrintDictionary(emptyDict);

        // Task 2: Get Existing Dictionary
        Dictionary<int, string> existingDict = DialingCodes.GetExistingDictionary();
        Console.WriteLine("\nTask 2: Existing Dictionary");
        PrintDictionary(existingDict);

        // Task 3: Add Country to Empty Dictionary
        Dictionary<int, string> japanDict =
            DialingCodes.AddCountryToEmptyDictionary(81, "Japan");
        Console.WriteLine("\nTask 3: Add Country to Empty Dictionary");
        PrintDictionary(japanDict);

        // Task 4: Add Country to Existing Dictionary
        DialingCodes.AddCountryToExistingDictionary(existingDict, 44, "United Kingdom");
        Console.WriteLine("\nTask 4: Add Country to Existing Dictionary");
        PrintDictionary(existingDict);

        // Task 5: Retrieve Country Name
        Console.WriteLine("\nTask 5: Retrieve Country Name");
        Console.WriteLine("Country Code 91: " +
            DialingCodes.GetCountryNameFromDictionary(existingDict, 91));
        Console.WriteLine("Country Code 99: " +
            DialingCodes.GetCountryNameFromDictionary(existingDict, 99));

        // Task 6: Check if Country Code Exists
        Console.WriteLine("\nTask 6: Check Code Exists");
        Console.WriteLine("Code 1 exists? " +
            DialingCodes.CheckCodeExists(existingDict, 1));
        Console.WriteLine("Code 999 exists? " +
            DialingCodes.CheckCodeExists(existingDict, 999));

        // Task 7: Update Existing Country Name
        DialingCodes.UpdateDictionary(existingDict, 91, "Republic of India");
        Console.WriteLine("\nTask 7: Update Country Name");
        PrintDictionary(existingDict);

        // Task 8: Remove Country
        DialingCodes.RemoveCountryFromDictionary(existingDict, 1);
        Console.WriteLine("\nTask 8: Remove Country Code 1");
        PrintDictionary(existingDict);

        // Task 9: Find Longest Country Name
        string longestCountry =
        DialingCodes.FindLongestCountryName(existingDict);
        Console.WriteLine("\nTask 9: Longest Country Name");
        Console.WriteLine(longestCountry);
    

    }

     static void PrintDictionary(Dictionary<int, string> dict)
    {
        if (dict.Count == 0)
        {
            Console.WriteLine("{ }");
            return;
        }

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
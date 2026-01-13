// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using DialingCodesApp;
using AutonomousRobot.AI;
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
        // Dictionary<int, string> emptyDict = DialingCodes.GetEmptyDictionary();
        // Console.WriteLine("Task 1: Empty Dictionary");
        // PrintDictionary(emptyDict);

        // // Task 2: Get Existing Dictionary
        // Dictionary<int, string> existingDict = DialingCodes.GetExistingDictionary();
        // Console.WriteLine("\nTask 2: Existing Dictionary");
        // PrintDictionary(existingDict);

        // // Task 3: Add Country to Empty Dictionary
        // Dictionary<int, string> japanDict =
        //     DialingCodes.AddCountryToEmptyDictionary(81, "Japan");
        // Console.WriteLine("\nTask 3: Add Country to Empty Dictionary");
        // PrintDictionary(japanDict);

        // // Task 4: Add Country to Existing Dictionary
        // DialingCodes.AddCountryToExistingDictionary(existingDict, 44, "United Kingdom");
        // Console.WriteLine("\nTask 4: Add Country to Existing Dictionary");
        // PrintDictionary(existingDict);

        // // Task 5: Retrieve Country Name
        // Console.WriteLine("\nTask 5: Retrieve Country Name");
        // Console.WriteLine("Country Code 91: " +
        //     DialingCodes.GetCountryNameFromDictionary(existingDict, 91));
        // Console.WriteLine("Country Code 99: " +
        //     DialingCodes.GetCountryNameFromDictionary(existingDict, 99));

        // // Task 6: Check if Country Code Exists
        // Console.WriteLine("\nTask 6: Check Code Exists");
        // Console.WriteLine("Code 1 exists? " +
        //     DialingCodes.CheckCodeExists(existingDict, 1));
        // Console.WriteLine("Code 999 exists? " +
        //     DialingCodes.CheckCodeExists(existingDict, 999));

        // // Task 7: Update Existing Country Name
        // DialingCodes.UpdateDictionary(existingDict, 91, "Republic of India");
        // Console.WriteLine("\nTask 7: Update Country Name");
        // PrintDictionary(existingDict);

        // // Task 8: Remove Country
        // DialingCodes.RemoveCountryFromDictionary(existingDict, 1);
        // Console.WriteLine("\nTask 8: Remove Country Code 1");
        // PrintDictionary(existingDict);

        // // Task 9: Find Longest Country Name
        // string longestCountry =
        // DialingCodes.FindLongestCountryName(existingDict);
        // Console.WriteLine("\nTask 9: Longest Country Name");
        // Console.WriteLine(longestCountry);

        // List<SensorReading> sensorHistory = new List<SensorReading>
        //     {
        //         new SensorReading { SensorId = 1, Type = "Distance", Value = 0.8, Confidence = 0.9, Timestamp = DateTime.Now.AddSeconds(-9) },
        //         new SensorReading { SensorId = 2, Type = "Battery", Value = 18, Confidence = 0.8, Timestamp = DateTime.Now.AddSeconds(-8) },
        //         new SensorReading { SensorId = 3, Type = "Temperature", Value = 92, Confidence = 0.7, Timestamp = DateTime.Now.AddSeconds(-7) },
        //         new SensorReading { SensorId = 4, Type = "Vibration", Value = 8.2, Confidence = 0.6, Timestamp = DateTime.Now.AddSeconds(-6) },
        //         new SensorReading { SensorId = 5, Type = "Battery", Value = 75, Confidence = 0.9, Timestamp = DateTime.Now.AddSeconds(-5) },
        //         new SensorReading { SensorId = 6, Type = "Distance", Value = 2.5, Confidence = 0.5, Timestamp = DateTime.Now.AddSeconds(-4) }
        //     };

        //     DateTime fromTime = DateTime.Now.AddSeconds(-10);

        //     // STRICT EXECUTION ORDER
        //     var recentReadings = DecisionEngine.GetRecentReadings(sensorHistory, fromTime);
        //     var batteryCritical = DecisionEngine.IsBatteryCritical(recentReadings);
        //     var nearestDistance = DecisionEngine.GetNearestObstacleDistance(recentReadings);
        //     var temperatureSafe = DecisionEngine.IsTemperatureSafe(recentReadings);
        //     var avgVibration = DecisionEngine.GetAverageVibration(recentReadings);
        //     var sensorHealth = DecisionEngine.CalculateSensorHealth(sensorHistory);
        //     var faultySensors = DecisionEngine.DetectFaultySensors(sensorHistory);
        //     //var batteryDrain = DecisionEngine.IsBatteryDrainingFast(sensorHistory);
        //     var weightedDistance = DecisionEngine.GetWeightedDistance(recentReadings);
        //     var action = DecisionEngine.DecideRobotAction(recentReadings, sensorHistory);

        //     Console.WriteLine($"Robot Action: {action}");

        //Ultra Enterprise SDLC Lifecycle Orchestrator
        //Initialize the SDLC engine
        EnterpriseSDLCEngine engine = new EnterpriseSDLCEngine();

        //Register business requirements
        engine.AddRequirement(
            "Single Sign-On integration across enterprise apps",
            RiskLevel.High
        );

        engine.AddRequirement(
            "Real-time Fraud Detection System",
            RiskLevel.Critical
        );
  
        //Create SDLC work items
        WorkItem designSSO = engine.CreateWorkItem(
            "Design SSO",
            SDLCStage.Design
        );

        WorkItem devSSO = engine.CreateWorkItem(
            "Develop SSO",
            SDLCStage.Development
        );

        WorkItem testSSO = engine.CreateWorkItem(
            "Test SSO",
            SDLCStage.Testing
        );

        //Define dependencies between work items
        engine.AddDependency(devSSO.Id, designSSO.Id);
        engine.AddDependency(testSSO.Id, devSSO.Id);

        //Register test suites
        engine.RegisterTestSuite("SSO-Regression-Suite");
        engine.RegisterTestSuite("SSO-Security-Smoke");

        //Plan the design stage
        engine.PlanStage(SDLCStage.Design);

        //Execute planned work items
        engine.ExecuteNext();
        engine.ExecuteNext();

        //Deploy a release
        engine.DeployRelease("v3.4.1");

        //Record quality metrics
        engine.RecordQualityMetric("Code Coverage", 91.7);
        engine.RecordQualityMetric("Security Score", 97.3);

        //Perform rollback
        engine.RollbackRelease();

        //Display audit history
        Console.WriteLine("\n===== AUDIT LEDGER =====");
        engine.PrintAuditLedger();

        //Display release quality scoreboard
        Console.WriteLine("\n===== RELEASE QUALITY SCOREBOARD =====");
        engine.PrintReleaseScoreboard();

        Console.WriteLine("\nExecution completed successfully.");
    

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
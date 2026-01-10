using System;
using System.Collections.Generic;


namespace DialingCodesApp
{
    // DialingCodes Utility Class
    public static class DialingCodes{
        // Task 1: Create an Empty Dialing Code Dictionary
        public static Dictionary<int, string> GetEmptyDictionary(){
            return new Dictionary<int, string>();
        }

        // Task 2:Create a Dictionary with Predefined Country Codes
        public static Dictionary<int, string> GetExistingDictionary(){
            return new Dictionary<int, string>
            {
                { 1, "United States of America" },
                { 55, "Brazil" },
                { 91, "India" }
            };
        }

        // Task 3: Add a Country to an Empty Dictionary
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName){
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(countryCode, countryName);
            return dict;
        }

        // Task 4: Add a Country to an Existing Dictionary
        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary,int countryCode,string countryName){
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        // Task 5: Retrieve a Country Name Using Country Code
        public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                return existingDictionary[countryCode];
            }
            return string.Empty;
        }

        // Task 6: Check if a Country Code Exists
        public static bool CheckCodeExists(
            Dictionary<int, string> existingDictionary,
            int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }

        // Task 7: Update an Existing Country Name
        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary,int countryCode,string countryName){
            if (existingDictionary.ContainsKey(countryCode)){
                existingDictionary[countryCode] = countryName;
            }
            return existingDictionary;
        }

        // Task 8: Remove a Country from Dictionary
        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary,int countryCode){
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        // Task 9: Find the Longest Country Name
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary){
            if (existingDictionary.Count == 0){
                return string.Empty;
            }

            string longestName = string.Empty;

            foreach (var country in existingDictionary.Values){
                if (country.Length > longestName.Length){
                    longestName = country;
                }
            }

            return longestName;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

class FlipKeyLogicalProblem{
   public string CleanseAndInvert(string input){
        //step1:input is not null or empty and has at least 6 characters
        if(string.IsNullOrEmpty(input) || input.Length<6){
            return "Invalid Input"; // Return empty string for null or empty input
        }
        //step2:input contains only alphabetic characters
        foreach(var ch in input){
            if(!char.IsLetter(ch)){
                return "Invalid Input"; // Return empty string if non-alphabetic character found
            }
        }
        //step3:logic to remove even ASCII characters and reverse the string
        string newInput=input.ToLower();
        string result="";
        foreach(var ch in newInput){
            if((int)ch%2==0){
                continue; //skip even ASCII values
            }else{
                result+=ch;
            }
        }
        //reverse the result string
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        string str = new string(charArray);

        
       string finalAns="";
       for(int i=0;i<str.Length;i++){
            if(i%2==0){
                finalAns += char.ToUpper(str[i]);
            }else{
                finalAns += char.ToLower(str[i]);
            }
        }
        return finalAns;
        
   }
}


//using stringbuilder for better performance
// using System;

// class FlipKeyLogicalProblem
// {
//     public string CleanseAndInvert(string input)
//     {
//         // Step 1: Validate input
//         if (string.IsNullOrEmpty(input) || input.Length < 6)
//         {
//             return "";
//         }

//         // Step 2: Check only alphabetic characters
//         foreach (char ch in input)
//         {
//             if (!char.IsLetter(ch))
//             {
//                 return "";
//             }
//         }

//         // Step 3: Convert to lowercase
//         string newInput = input.ToLower();
//         string result = "";

//         // Step 4: Remove characters with even ASCII value
//         foreach (char ch in newInput)
//         {
//             if ((int)ch % 2 != 0)
//             {
//                 result += ch;
//             }
//         }

//         // Step 5: Reverse the string
//         char[] charArray = result.ToCharArray();
//         Array.Reverse(charArray);
//         string reversed = new string(charArray);

//         // Step 6: Alternate case
//         string finalAns = "";
//         for (int i = 0; i < reversed.Length; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 finalAns += char.ToUpper(reversed[i]);
//             }
//             else
//             {
//                 finalAns += char.ToLower(reversed[i]);
//             }
//         }

//         return finalAns;
//     }
// }

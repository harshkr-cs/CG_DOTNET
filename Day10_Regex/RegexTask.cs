using System;
using System.Text.RegularExpressions;

namespace LogProcessing{
    class LogParser{
        private readonly string validLineRegexPattern=@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";//Stores regex to validate log severity 
        private readonly string splitLineRegexPattern=@"<\*{3}>|<={4}>|<\^\*>";//Stores regex used to split log lines 
        private readonly string quotedPasswordRegexPattern="\"[^\"]*password[^\"]*\"";//Stores regex to find passwords inside quotes 
        private readonly string endOfLineRegexPattern= @"end-of-line\d+";//Stores regex to remove end-of-line markers 
        private readonly string weakPasswordRegexPattern=@"\bpassword[a-z0-9]+\b";//Stores regex to detect weak passwords 
        
        //Task-1Check whether the log line starts with a valid severity level: 
        //[TRC], [DBG], [INF], [WRN], [ERR], [FTL] 
        public bool IsValidLine(string text){
            // string pattern= @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
            // if(Regex.IsMatch(text,validLineRegexPattern)){
            //     // Console.WriteLine("Valid Log Lines");
            //     return true;
            // }else{
            //     // Console.WriteLine("Invalid Log Line");
            //     return false;
            // }
            return Regex.IsMatch(text,validLineRegexPattern);//return true or false
        }
        //Task-2Split Log Line(<***>, <====>, <^*>) 
        public string[] SplitLogLine(string text){
            //string pattern = @"<\*{3}>|<={4}>|<\^\*>";
            return Regex.Split(text, splitLineRegexPattern);//return string array
        } 
        
        //Task 3: Count Quoted Passwords
        public int CountQuotedPasswords(string lines){
            //string pattern = "\"[^\"]*password[^\"]*\"";
            MatchCollection matches = Regex.Matches(
                lines,
                quotedPasswordRegexPattern
            );

            return matches.Count;
        } 
        //Task 4: Remove End-of-Line Marker
        public string RemoveEndOfLineText(string line){
            // string pattern = @"end-of-line\d+";
            return Regex.Replace(line, endOfLineRegexPattern, "").Trim();
        }

        public string[] ListLinesWithPasswords(string[] lines){
            //string pattern = @"\bpassword[a-z0-9]+\b";
            List<string> result = new List<string>();

            foreach (string line in lines){
                Match match = Regex.Match(
                    line,
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase
                );

                if (match.Success){
                    result.Add(match.Value + ": " + line);
                }
                else{
                    result.Add("--------: " + line);
                }
            }

            return result.ToArray();
        }
        
            // string[] tests ={
            // "password=abc123",
            // "passwordTemp456",
            // "password=****",
            // "password=XXXXX",
            // "password=####"
            // };
        //Task9.5
        public void IgnoredMaked(string[] tests){
             string pattern = @"\bpassword(?!=(\*+|X+|#+))=?[a-zA-Z0-9]+\b";
            foreach (string t in tests) {
                Console.WriteLine($"{t} -> {Regex.IsMatch(t, pattern, RegexOptions.IgnoreCase)}");
            }
        }

        //Task9.9-Validate ISO-8601 Timestamp Strictly 
        public void ValidateISO8601Timestamp(string[] tests){
            string pattern =@"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])T([01]\d|2[0-3]):[0-5]\d:[0-5]\dZ$";
               
            foreach (string t in tests){
                Console.WriteLine(t + "->" + Regex.IsMatch(t, pattern));
            }
        }
    }
}
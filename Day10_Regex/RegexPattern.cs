using System;
using System.Text.RegularExpressions;


class RegexDemo{
    public static void RegexMatch(){
        //Regex.IsMatch()
        // string sentence="abc123";//true
        // string sentence="123_123";//true
        // string pattern=@"\d";
        // bool result=Regex.IsMatch(sentence,pattern);
        // Console.WriteLine(result);
        
        //Regex.Match(,);
        //\d → means any digit (0–9)
        //+ → means one or more times
        // string pattern=@"\d+";
        // Match m=Regex.Match("Amount:5000 hello 6000",pattern);
        // Console.WriteLine(m);//first actual matched content

        // string input = "Bill:200 Tax:50 Discount:30";
        // string pattern = @"\d+";
        // Match m=Regex.Match(input,pattern);//return first match pattern
        // Console.WriteLine(m.Value);
        // MatchCollection matches = Regex.Matches(input, pattern);

        // foreach(Match mth in matches){
        //     Console.Write(mth.Value + " ");//return all matches pattern
        // }

        //MatchCollection matches=Regex.Matches("10A20B30",@"\w");//word character
        // Match m=Regex.Match("10A20B30",@"\w");//word character
        // MatchCollection matches=Regex.Matches("10A20B30@",@"\W");//Non-word character(special symbol)->@
        // Match m=Regex.Match("10A20B30@",@"\W");//Non-word character(special symbol)->@
        // Console.WriteLine(m.Value + " ");
        // foreach(Match mth in matches){
        //     Console.Write(mth.Value + " ");//return all matches pattern
        // }

        // MatchCollection matches=Regex.Matches("file.txt",@"\.txt");//.means any character
        //  foreach(Match mth in matches){
        //     Console.Write(mth.Value + " ");//return all matches pattern
        // }

        // MatchCollection matches=Regex.Matches(@"C:\abc\file.txt",@"\\");
        //  foreach(Match mth in matches){
        //     Console.Write(mth.Value + " ");//return all matches pattern
        // }
        // Match m=Regex.Match("Date:2025-12-29",@"(\d(4))-(\d(2))-(\d(2))");
        // Match m1 = Regex.Match("Date: 2025-12-29", @"(\d{4})-(\d{2})-(\d{2})");
        // Console.WriteLine(m1.Value);

        //Regex.Replace()
        //Regex.Split()
        // string[] parts=Regex.Split("A;B;C",@"\");

        //Named Group
        // string input="Amount=5000";
        // string pattern=@"Amount=(?<value>\d)";
        // string input="1992-02-11";
        // string pattern=@"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";//1992-02-11
        // string input="1992-02-11,2010-10-15";
        // string pattern=@"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // Match m=Regex.Match(input,pattern);//first match pattern
        // Console.WriteLine(m.Value); //1992-02-11
        // MatchCollection mth=Regex.Matches(input,pattern);//print all matche pattern
        // foreach(Match i in mth){
        //     Console.Write(i+" ");
        // }
        
      
        // string input="1992-02-11,2010-10-15";
        // string pattern=@"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // Match m=Regex.Match(input,pattern);//first match pattern
        
        // Console.WriteLine(m.Groups["year"].Value);//1992
        // Console.WriteLine(m.Groups["month"].Value);//02
        // Console.WriteLine(m.Groups["date"].Value);//11

        // MatchCollection mth=Regex.Matches(input,pattern);//print all matche pattern
        // foreach(Match i in mth){
        //     Console.Write(i.Groups["year"]+" "+i.Groups["month"]+" "+i.Groups["date"]+ " ");//1992 02 11 2010 10 15
        // }
        // Console.WriteLine();

        // string input="a123e";//a123e
        // string pattern=@"a...e";
        // string input="grapple";//apple
        // string pattern=@"a...e";
        // string input="apples";//apple
        // string pattern=@"a...e";
        // string input="apples";//nothing printing b/c between a and e 2 character come
        // string pattern=@"a..e";

        // Match m=Regex.Match(input,pattern);
        // Console.WriteLine(m.Value);

        List<string> Emails = new List<string>{
            "john.doe@gmail.com",
            "alice_123@yahoo.in",
            "mark.smith@company.com",
            "support-abc@banking.co.in",
            "user.nametag@domain.org",
            "john.doe@gmail",          // Missing domain extension
            "alice@@yahoo.com",        // Double @
            "mark.smith@.com",         // Domain missing name
            "support@banking..com",    // Double dot in domain
            "user name@gmail.com",     // Space not allowed
            "@domain.com",             // Missing username
            "admin@domain",            // No top-level domain
            "info@domain,com",         // Comma instead of dot
            "finance#dept@corp.com",   // Invalid character #
            "plainaddress"             // Missing @ and domain

        };
        string pattern=@"\b[\w.-]+@[\w.-]+\.\w{2,}\b";
        // foreach(var email in Emails){
        //     if(Regex.IsMatch(email,pattern)){
        //         Console.WriteLine(email + " is a valid email format");
        //     }else{
        //         Console.WriteLine(email + " is not a valid email format");
        //     }
        // }
         for(var i=0;i<Emails.Count;i++){
            if(Regex.IsMatch(Emails[i],pattern)){
                Console.WriteLine(Emails[i] + " is a valid email format");
            }else{
                Console.WriteLine(Emails[i] + " is not a valid email format");
            }
        }
        // [\w.-]+ → Username part
        // [] → character set
        // \w → letters (a–z, A–Z), digits (0–9), underscore _
        // . → dot allowed
        // - → hyphen allowed
        // + → one or more characters
       
        // Console.WriteLine();
    }
}
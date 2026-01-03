using System;
System.Collections.Generic;

class CreatorStats{
    public string CreatorName {get; set;}
    public double[] WeeklyLikes {get; set;}

}

class Program1{
    public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();
    //Register Creator
    public void RegisterCreator(CreatorStats record){
        EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold){
      
        Dictionary<string,int> result=new Dictionary<string,int>();
        foreach(var record in records){
            int count=0;
            foreach (double likes in record.WeeklyLikes){
                if (likes >= likeThreshold){
                    count++;
                }
            }
             if (count > 0){
                result.Add(record.CreatorName, count);
            }
        }

        return result;
    }
    
    //calculate avg of weekly likes
    public double CalculateAverageLikes(){  
        double totalLikes = 0;
        int totalWeeks = 0;

        foreach (var creator in EngagementBoard){
            foreach(double likes in creator.WeeklyLikes){
                totalLikes += likes;
                totalWeeks++;
            }
        }
         if (totalWeeks == 0)
            return 0;
        
        return totalLikes/totalWeeks;
    }
}
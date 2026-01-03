using System;
using System.Collections.Generic;

//-----------------ABSTRACT BASE CLASS -----------------
public abstract class EmployeeRecord{
    // Common properties
    public string EmployeeName { get; set; }
    public double[] WeeklyHours { get; set; }

    public abstract double GetMonthlyPay();
}

// ================= FULL TIME EMPLOYEE =================
public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public double MonthlyBonus { get; set; }

    public override double GetMonthlyPay(){
        double totalHours = 0;
        // foreach (double h in WeeklyHours)
        //     totalHours += h;
        for(int i=0;i<WeeklyHours.Length;i++){
            totalHours += WeeklyHours[i];
        }

        return (totalHours * HourlyRate) + MonthlyBonus;
    }
}

//------------------------CONTRACT EMPLOYEE------------------------
public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }

    public override double GetMonthlyPay()
    {
        double totalHours = 0;
        foreach (double h in WeeklyHours)
            totalHours += h;

        return totalHours * HourlyRate;
    }
}

public class PayRollService
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(
        List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var emp in records)
        {
            int count = 0;
            foreach (var h in emp.WeeklyHours)
            {
                if (h >= hoursThreshold)
                    count++;
            }

            if (count > 0)
                result.Add(emp.EmployeeName, count);
        }

        return result;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0)
            return 0;

        double sum = 0;
        foreach (var emp in PayrollBoard)
            sum += emp.GetMonthlyPay();   // POLYMORPHISM

        return sum / PayrollBoard.Count;
    }
}
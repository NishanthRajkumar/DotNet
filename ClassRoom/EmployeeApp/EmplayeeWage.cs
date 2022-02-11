using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp;

internal class EmployeeWage
{
    // Constant variables declared here
    const int IS_FULL_TIME = 1;
    const int IS_PART_TIME = 0;
    const int IS_PRESENT = 1;
    const int IS_ABSENT = 0;

    // Attributes of the class declared here
    private int totalDaysWorked;
    private int totalHoursWorked;
    private string company;
    private int empRatePerHour;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    // Random object declared
    static Random random = new Random();

    // Constructor
    public EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        totalDaysWorked = 0;
        totalEmpWage = 0;
        totalHoursWorked = 0;
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }

    // Default Constructor
    public EmployeeWage()
    {
        totalDaysWorked = 0;
        totalEmpWage = 0;
        totalHoursWorked = 0;
        company = "NA";
        empRatePerHour = 20;
        numOfWorkingDays = 20;
        maxHoursPerMonth = 100;
    }

    // Resets class attributes to default values given in constructor
    public void Reset()
    {
        totalDaysWorked = 0;
        totalEmpWage = 0;
        totalHoursWorked = 0;
    }

    // Gets attendance of employee using Random
    private int GetAttendance()
    {
        int checkAttendance = random.Next(0, 2);
        if (checkAttendance == IS_PRESENT)
            return IS_PRESENT;
        else
            return IS_ABSENT;
    }

    // Calculates Daily Wage
    private int GetDailyWage()
    {
        int dailyWage = 0;
        int dailyHours = 0;
        int empCheck = random.Next(0, 2);
        switch (empCheck)
        {
            case IS_FULL_TIME:
                dailyHours = 8;
                break;
            case IS_PART_TIME:
                dailyHours = 4;
                break;
            default:
                dailyHours = 0;
                break;
        }
        totalHoursWorked += dailyHours;
        dailyWage = dailyHours * empRatePerHour;
        return dailyWage;
    }

    // Gets monthly wage after checkking attendance for the working days
    public void MonthlyWage()
    {
        for (int i = 0; i < numOfWorkingDays; i++)
            totalDaysWorked += GetAttendance();
        for (int j = 0; j < totalDaysWorked; j++)
            totalEmpWage += GetDailyWage();
    }

    // Until total hours reaches 100 or total days = 20
    public void MeetWageCondition()
    {
        while (totalDaysWorked != numOfWorkingDays && totalHoursWorked < maxHoursPerMonth)
        {
            Reset();
            MonthlyWage();
        }
    }

    // Displays the values of the class atributes at the time this method is called
    public void Display()
    {
        Console.WriteLine("Company name: " + company);
        Console.WriteLine("Total Hours worked: " + totalHoursWorked);
        Console.WriteLine("Total Days worked: " + totalDaysWorked);
        Console.WriteLine("Monthly Wage: " + totalEmpWage);
    }
}
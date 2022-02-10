using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.UseCase10;

internal class CompanyEmpWage
{
    // class attributes declared here
    internal int totalDaysWorked;
    internal int totalHoursWorked;
    internal string company;
    internal int empRatePerHour;
    internal int numOfWorkingDays;
    internal int maxHoursPerMonth;
    internal int totalEmpWage;

    // Random object declared
    static Random random = new Random();

    // Constructor
    public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        totalDaysWorked = 0;
        totalEmpWage = 0;
        totalHoursWorked = 0;
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void setTotalEmpWage(int totalEmpWage)
    {
        this.totalEmpWage = totalEmpWage;
    }

    public string toString()
    {
        return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
    }
}
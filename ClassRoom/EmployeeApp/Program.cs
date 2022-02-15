using EmployeeApp.UseCase10;
using EmployeeApp;

Console.Title = "Employee App";
Console.WriteLine("-----------------Employee Wage Calculation App-----------------");
/*EmployeeWage employee = new EmployeeWage("Google", 175, 20, 100);
employee.MeetWageCondition();
employee.Display();*/

EmpWageBuilderArray obj = new EmpWageBuilderArray();
obj.addCompanyEmpWage("Google", 175, 20, 100);
obj.addCompanyEmpWage("Facebook", 175, 20, 100);
obj.addCompanyEmpWage("SpaceX", 175, 20, 100);
obj.addCompanyEmpWage("Tesla", 175, 20, 100);
obj.addCompanyEmpWage("L&T", 175, 20, 100);

obj.computeEmpWage();

Console.ReadKey();
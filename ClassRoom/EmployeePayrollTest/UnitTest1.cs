using EmployeePayrollService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeePayrollTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        EmployeeRepo repo = new();
        EmployeeModel employee = new();
        employee.EmployeeName = "Mohan";
        employee.Department = "Tech1";
        employee.PhoneNumber = "6302907678";
        employee.Address = "02-Patna";
        employee.Gender = 'M';
        employee.BasicPay = 10000.00M;
        employee.Deductions = 1500.00;
        employee.StartDate = Convert.ToDateTime("2020-11-03");
        //Mock<EmployeeRepo> mockObj = new Mock<EmployeeRepo>();
        //mockObj.Setup(t=>t.AddEmployee(It.IsIn<EmployeeModel>)).return (true);
        var result = repo.AddEmployee(employee);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetAllEmployeeShouldReturnListOfRecords()
    {
        EmployeeRepo repo = new();
        var result = repo.GetAllEmployee();
        Assert.IsTrue(result);
    }
}

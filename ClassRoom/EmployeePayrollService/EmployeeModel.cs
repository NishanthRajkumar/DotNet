namespace EmployeePayrollService;

public class EmployeeModel
{
    public int EmployeeID { get; set; }
    public string? EmployeeName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Department { get; set; }
    public char Gender { get; set; }
    public decimal BasicPay { get; set; }
    public double Deductions { get; set; }
    public double TaxablePay { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }
    public DateTime StartDate { get; set; }
}

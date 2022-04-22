namespace EmployeePayrollUsingThreads;

public class EmployeeDetails
{
    public EmployeeDetails(int EmployeeID, string EmployeeName, string PhoneNumber, string Address, string Department, char Gender, string City, int BasicPay, int TaxablePay, int Tax, string Country)
    {
        this.EmployeeID = EmployeeID;
        this.EmployeeName = EmployeeName;
        this.PhoneNumber = PhoneNumber;
        this.Address = Address;
        this.Department = Department;
        this.Gender = Gender;
        this.City = City;
        this.BasicPay = BasicPay;
        this.TaxablePay = TaxablePay;
        this.Tax = Tax;
        this.Country = Country;
    }

    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }

    public char Gender { get; set; }
    public string PhoneNumber { get; set; }
    public double BasicPay { get; set; }
    public string Address { get; set; }
    public double Deduction { get; set; }
    public string Department { get; set; }
    public double TaxablePay { get; set; }
    public string City { get; set; }
    public double Tax { get; set; }
    public double NetPay { get; set; }
    public string Country { get; set; }

}

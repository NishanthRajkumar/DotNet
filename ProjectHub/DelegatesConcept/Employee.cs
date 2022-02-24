namespace DelegatesConcept;


public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion IsEmployeeEligible)
    {
        foreach (Employee employee in lstEmployees)
        {
            if (IsEmployeeEligible(employee))
            {
                Console.WriteLine("Employee {0} Promoted", employee.Name);
            }
        }
    }
}
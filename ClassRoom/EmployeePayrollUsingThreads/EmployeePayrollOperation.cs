namespace EmployeePayrollUsingThreads;

public class EmployeePayrollOperation
{
    public List<EmployeeDetails> employeePayrollDetailsList = new List<EmployeeDetails>();

    public void Reset()
    {
        employeePayrollDetailsList.Clear();
    }

    public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDetailsList)
    {
        employeePayrollDetailsList.ForEach(employeeData =>
        {
            Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
            this.addEmployeeToPayroll(employeeData);
            Console.WriteLine("Employee added: " + employeeData.EmployeeName);
        });
        Console.WriteLine(this.employeePayrollDetailsList.Count);
    }


    public void addEmployeeToPayroll(EmployeeDetails emp)
    {
        employeePayrollDetailsList.Add(emp);
    }

    public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeePayrollDetailsList)
    {
        List<Task> listOfTasks = new();
        employeePayrollDetailsList.ForEach(employeeData =>
        {
            //Console.WriteLine("abc");
            Task thread = new Task(() =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);
            });
            listOfTasks.Add(thread);
            thread.Start();
        });
        Task.WaitAll(listOfTasks.ToArray());
        Console.WriteLine(this.employeePayrollDetailsList.Count);
    }

}

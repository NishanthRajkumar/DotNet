using System.Data.SqlClient;

namespace EmployeePayrollService;

public class EmployeeRepo
{
    const string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=payroll_service;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    readonly SqlConnection connection = new(connectionString);
    public bool GetAllEmployee()
    {
        try
        {
            EmployeeModel employeeModel = new();
            using (connection)
            {
                string query = @"Select * from employee_payroll1;";
                SqlCommand cmd = new(query, connection);
                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //employeeModel.EmployeeID = dr.GetInt32(0);
                        employeeModel.EmployeeID = Convert.ToInt32(dr["id"]);
                        employeeModel.EmployeeName = Convert.ToString(dr["name"]);
                        employeeModel.PhoneNumber = Convert.ToString(dr["phone"]);
                        employeeModel.Address = Convert.ToString(dr["address"]);
                        employeeModel.BasicPay = Convert.ToInt32(dr["basic_pay"]);
                        employeeModel.StartDate = Convert.ToDateTime(dr["start_date"]);
                        employeeModel.Gender = Convert.ToChar(dr["gender"]);
                        employeeModel.Department = Convert.ToString(dr["department"]);
                        employeeModel.Deductions = Convert.ToDouble(dr["deduction"]);
                        employeeModel.TaxablePay = Convert.ToDouble(dr["taxable_pay"]);
                        employeeModel.Tax = Convert.ToDouble(dr["income_tax"]);
                        employeeModel.NetPay = Convert.ToDouble(dr["net_pay"]);
                        System.Console.WriteLine(employeeModel.EmployeeName + " " + employeeModel.BasicPay + " " + employeeModel.StartDate + " " + employeeModel.Gender + " " + employeeModel.PhoneNumber + " " + employeeModel.Address + " " + employeeModel.Department + " " + employeeModel.Deductions + " " + employeeModel.TaxablePay + " " + employeeModel.Tax + " " + employeeModel.NetPay);
                        System.Console.WriteLine("\n");
                    }
                }
                else
                {
                    System.Console.WriteLine("No data found");
                    return false;
                }
                return true;
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            return false;
        }
    }

    public bool AddEmployee(EmployeeModel model)
    {
        try
        {
            using (connection)
            {
                //var qury=values()
                SqlCommand command = new("SpAddEmployeeDetails", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@Department", model.Department);
                command.Parameters.AddWithValue("@Gender", model.Gender);
                command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                command.Parameters.AddWithValue("@Deductions", model.Deductions);
                command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                command.Parameters.AddWithValue("@Tax", model.Tax);
                command.Parameters.AddWithValue("@NetPay", model.NetPay);
                command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                //command.Parameters.AddWithValue("@City", model.City);
                //command.Parameters.AddWithValue("@Country", model.Country);
                connection.Open();
                var result = command.ExecuteNonQuery();
                connection.Close();
                if (result != 0)
                    return true;
                return false;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return false;
    }
}

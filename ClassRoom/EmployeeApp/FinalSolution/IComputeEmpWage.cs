namespace EmployeeApp.FinalSolution
{
    internal interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void ComputeEmpWage();
        int GetTotalWage(string company);
    }
}

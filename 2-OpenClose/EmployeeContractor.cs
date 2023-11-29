namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string Name { get ; set ; }
        public int HoursWorked { get; set; }
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Name = fullname;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 40000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}
namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public string Name { get ; set ; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Name = fullname;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}
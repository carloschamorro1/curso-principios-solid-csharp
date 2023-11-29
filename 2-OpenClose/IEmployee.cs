namespace OpenClose
{
    public interface IEmployee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public decimal CalculateSalaryMonthly();
    }
}

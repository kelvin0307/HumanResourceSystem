namespace HumanResourceSystem.Model
{
    public class Salary
    {
        public int Id { get; set; }
        public double YearSalary { get; set; }

        // Navigation Propery
        public Contract Contract { get; set; }

        // Foreign Key
        public int ContractId { get; set; }

    }
}

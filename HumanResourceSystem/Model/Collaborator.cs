namespace HumanResourceSystem.Model
{
    public class Collaborator
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
        public string FirstName { get; set; }
        public string? Insertion { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Adress { get; set; }
        public string PostalCode { get; set; }
        public string BankAccount { get; set; }
        public string? ImageURL { get; set; }


        // Collection Navigation Properties
        // Zero To Many
        public IEnumerable<Declaration>? Declarations { get; set; }
        public IEnumerable<ItemInUse>? ItemsInUse { get; set; }
        public IEnumerable<DayOff>? DaysOff { get; set; }

        // One To Many
        public IEnumerable<Contract> Contracts { get; set; }

        // One To One
        public Function Function { get; set; }
        public int FunctionId { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }

    }
}

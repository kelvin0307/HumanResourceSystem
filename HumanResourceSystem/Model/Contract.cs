namespace HumanResourceSystem.Model
{
    public class Contract
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Archieved { get; set; }
        public int ContractStatus { get; set; }

        // Navigation Property
        public Collaborator Collaborator { get; set; }

        // Foreign Key
        public int CollaboratorId { get; set; }

        // Collection Navigation Properties
        public Salary Salary { get; set; }
    }
}

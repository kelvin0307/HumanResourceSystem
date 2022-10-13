namespace HumanResourceSystem.Model
{
    public class Declaration
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public double MoneyAmount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }

        // One to one
        public int CollaboratorId { get; set; }         // Foreign key
        public Collaborator Collaborator { get; set; }  // Navigation Property

    }
}

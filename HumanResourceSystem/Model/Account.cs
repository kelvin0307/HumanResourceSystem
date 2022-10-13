namespace HumanResourceSystem.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Password { get; set; }

        // Navigation Property
        public Collaborator Collaborator { get; set; }

        // Foreign Key
        public int CollaboratorId { get; set; }
    }
}

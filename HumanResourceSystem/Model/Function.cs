namespace HumanResourceSystem.Model
{
    public class Function
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation Property
        public IEnumerable<Collaborator> Collaborator { get; set; }

        // Foreign Key
        public int CollaboratorId { get; set; }
    }
}

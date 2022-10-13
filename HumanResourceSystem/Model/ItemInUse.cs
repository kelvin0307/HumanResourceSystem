namespace HumanResourceSystem.Model
{
    public class ItemInUse
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation Property
        public Collaborator Collaborator { get; set; }

        // Foreign Key
        public int CollaboratorId { get; set; }

        // Collection Navigation Properties
        public IEnumerable<Inventory>? inventories { get; set; }
    }
}

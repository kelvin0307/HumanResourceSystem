namespace HumanResourceSystem.Model
{
    public class DayOff
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        // Navigation Propery
        public Collaborator Collaborator { get; set; }

        // Foreign Key
        public int CollaboratorId { get; set; }
    }
}

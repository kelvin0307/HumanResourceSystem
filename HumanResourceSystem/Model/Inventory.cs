namespace HumanResourceSystem.Model
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NewPrice { get; set; }
        public bool Bookable { get; set; }
        public string Condition { get; set; }

        // Property Key
        public ItemInUse ItemInUse { get; set; }

        // Foreign Key
        public int ItemInUseId { get; set; }
    }
}

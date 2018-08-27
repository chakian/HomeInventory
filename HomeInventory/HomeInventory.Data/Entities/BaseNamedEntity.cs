namespace HomeInventory.Data.Entities
{
    public class BaseNamedEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

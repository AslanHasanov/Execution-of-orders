namespace DemoApplication.Database.Models.Common
{
    public abstract class BaseEntity<Tkey>
    {
        public int Id { get; set; }
    }
}

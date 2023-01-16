using DemoApplication.Database.Models.Common;

namespace DemoApplication.Database.Models
{
    public class Subscribes : BaseEntity<int>
    {
        public string Email { get; set; }
    }
}

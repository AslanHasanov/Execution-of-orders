using DemoApplication.Database.Models.Common;

namespace DemoApplication.Database.Models
{
    public class Order: BaseEntity<string>, IAuditable
    {
        public User? User { get; set; }
        public Guid UserId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<OrderProduct>? OrderProducts { get; set; }
        public int Status { get; set; }
       
        public int SummaryTotalPrice { get; set; }
      
    }
}

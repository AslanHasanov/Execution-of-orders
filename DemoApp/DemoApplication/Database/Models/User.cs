using DemoApplication.Database.Models.Common;

namespace DemoApplication.Database.Models
{
    public class User : BaseEntity<Guid>, IAuditable
    {

        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Basket? Basket { get; set; }
        public Addres? Address { get; set; }

        public int? RoleId { get; set; }
        public Role? Roles { get; set; }

        public UserActivation? UserActivation { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public List<Order>? Orders { get; set; }


    }
}

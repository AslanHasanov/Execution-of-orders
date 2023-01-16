using Microsoft.Build.Framework;

namespace DemoApplication.Areas.Admin.ViewModels.Author
{
    public class ListItemViewModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public ListItemViewModel(int id, string name, string lastName)
        {
            Id = id;
            FirstName = name;
            LastName = lastName;
        }
        public ListItemViewModel()
        {

        }
    }
}

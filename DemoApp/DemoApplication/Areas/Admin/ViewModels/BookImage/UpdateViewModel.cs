using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Areas.Admin.ViewModels.BookImage
{
    public class UpdateViewModel
    {
        public int Id { get; set; }
        public IFormFile? Image { get; set; }
        public string? ImageUrL { get; set; }
    }
}

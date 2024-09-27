using System.ComponentModel.DataAnnotations;

namespace FlipCart.Areas.Admin.Models
{
    public class CategoryVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}

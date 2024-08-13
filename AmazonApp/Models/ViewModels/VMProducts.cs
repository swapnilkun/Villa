using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AmazonApp.Models.ViewModels
{
    public class VMProducts
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}

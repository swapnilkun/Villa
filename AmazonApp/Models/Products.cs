using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmazonApp.Models
{
    [Table("TblProduct")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Image { get; set; }
    }
}

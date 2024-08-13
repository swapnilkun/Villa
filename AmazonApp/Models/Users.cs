using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmazonApp.Models
{
    [Table("TblUsers")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(70)]
        public string Email { get; set; }

        [Required]
        [StringLength(8)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string FName { get; set; }

        [StringLength(20)]
        public string MName { get; set; }

        [Required]
        [StringLength(25)]
        public string LName { get; set; }

        [Required]
        public long MobNo { get; set; }

        
        public string ProfileImage { get; set; }
    }
}

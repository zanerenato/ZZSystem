using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("UserId")]
        [Required]
        public long UserId { get; set; }
        [Column("Login")]
        [Required]
        [MaxLength]
        public string Login { get; set; }
        [Column("Password")]
        [Required]
        [MaxLength]
        public string Password { get; set; }
    }

}

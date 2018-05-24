using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Logins")]
    public class Logins
    {
        [Key]
        [Column("LoginId")]
        [Required]
        public long LoginId { get; set; }
        [Column("UserId")]
        [Required]
        public long UserId { get; set; }
        [Column("IsLogin")]
        public bool? IsLogin { get; set; }
        [Column("DataId")]
        [Required]
        public long DataId { get; set; }
        [Column("HoraId")]
        [Required]
        public long HoraId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("DataId")]
        public Data Data { get; set; }
        [ForeignKey("HoraId")]
        public Time Hora { get; set; }
    }

}

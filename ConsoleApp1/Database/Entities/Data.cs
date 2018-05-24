using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZZSystem.Database.Entities
{
    [Table("Datas")]
    public class Data
    {
        [Key]
        [Column("DataId")]
        [Required]
        public long DataId { get; set; }
        [Column("Dia")]
        [Required]
        public int Dia { get; set; }
        [Column("Mes")]
        [Required]
        public int Mes { get; set; }
        [Column("Ano")]
        [Required]
        public int Ano { get; set; }
    }

}

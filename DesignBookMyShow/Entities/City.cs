using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("City")]
    public class City : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [StringLength(50)]
        public string CityName { get; set; }

        public ICollection<Theatre> Theatres= new List<Theatre>();
    }
}

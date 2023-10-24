using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Screen")]
    public class Screen : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public ICollection<Seat> Seats = new List<Seat>();
        public ICollection<Features> Feature = new List<Features>();
        public Theatre theatre { get; set; }
    }
}
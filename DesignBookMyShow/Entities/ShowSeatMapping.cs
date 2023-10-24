using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("ShowSeatMapping")]
    public class ShowSeatMapping : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Show ShowDetail { get; set; }
        public Seat SeatDetail { get; set; }
        public SeatStatus Status { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
    }
}
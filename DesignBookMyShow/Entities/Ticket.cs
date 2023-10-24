using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Ticket")]
    public class Ticket : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public TicketStatus Status { get; set; }
        public User UserDetails { get; set; }
        public decimal Amount { get; set; }
        public Coupon AppliedCoupon { get; set; }

        public ICollection<Payment> Payments = new List<Payment>();
        public ICollection<ShowSeatMapping> SeatShowDeatil = new List<ShowSeatMapping>();
    }
}

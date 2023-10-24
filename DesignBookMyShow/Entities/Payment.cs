using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Payment")]
    public class Payment : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long ReferenceNumber { get; set; }
        public PaymentMode Mode { get; set; }
        public decimal PaymentAmount { get; set; }
        public Ticket Ticket { get; set; }

    }
}

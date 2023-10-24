using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Seat")]
    public  class Seat : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long RowNumber { get; set; }
        public long ColumnNumber { get; set; }
        public SeatType Type { get; set; }
        public Screen screen { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Theatre")]
    public class Theatre:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [StringLength(100)]
        public string TheatreName { get; set; }
        [StringLength(100)]
        public string TheatreAddress { get; set; }
        public long TheatrePincode { get; set; }
        public City City { get; set; }

        public ICollection<Screen> Screens = new List<Screen>();
        public ICollection<Show> Shows = new List<Show>();
    }
}
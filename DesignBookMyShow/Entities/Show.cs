using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Shows")]
    public class Show : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Movie MovieDetails { get; set; }
        public DateTime ShowDateTime { get; set; }
        public string ShowDuration { get; set; }
        public ICollection<Features> ShowFeatures = new List<Features>();
    }
}
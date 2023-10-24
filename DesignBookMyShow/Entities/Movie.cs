using DesignBookMyShow.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignBookMyShow.Entities
{
    [Table("Movie")]
    public class Movie : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string MovieName { get; set; }
        public decimal MovieDuration { get; set; }
        public decimal Rating { get; set; }

        public ICollection<Features> MovieFeature = new List<Features>();
        public ICollection<Genre> MovieGenre = new List<Genre>();
        public ICollection<LanguageType> MovieLanguage = new List<LanguageType>();
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.Entities
{
    public class PointOfIntrest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        // navigation 
        [ForeignKey("CityId")]
        public City City { get; set; }
        // foregn key
        public int CityId { get; set; }

        public PointOfIntrest(string name) {


            Name = name;

        }

    }
}

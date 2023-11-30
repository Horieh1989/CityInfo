﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public City(string name)
        {
            Name = name;
        }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        public ICollection<PointOfIntrest> PointOfIntrests { get; set; } =
            new List<PointOfIntrest>();

    }
}

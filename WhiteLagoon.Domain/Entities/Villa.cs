using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entities
{
    public class Villa
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; } =string.Empty;
        public string? Description { get; set; }
        [Range(100, 10000)]
        [Display(Name ="Price per night")]
        public double Price { get; set; }
        public int Sqft { get; set; }
        [Range(1, 10)]
        public int Occupancy { get; set; }
        [Display(Name = "Image Url")]
        public string? ImageUrl { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string VillaCode { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatChaudhnt.Models
{
    public class Industry
    {
        [Key]
        public int IndustryId { get; set; } // Primary Key

        // ---- Basic Info ----
        [Required]
        [StringLength(100)]
        [Display(Name = "Industry Name")]
        public string Name { get; set; } = string.Empty;

        // ---- Additional Info ----
        [StringLength(500)]
        [Display(Name = "Description / Summary")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; } // nullable string

        [Display(Name = "Growing Industry?")]
        public bool IsGrowing { get; set; }

        // ---- Relationships ----
        [Display(Name = "Associated Companies")]
        public List<Company> Companies { get; set; } = new();
    }
}

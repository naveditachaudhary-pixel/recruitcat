using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatChaudhnt.Models
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; } // Primary Key

        // ---- Basic Info ----
        [Required]
        [StringLength(100)]
        [Display(Name = "Job Title")]
        public string Title { get; set; } = string.Empty;

        // ---- Salary Info ----
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Maximum Salary")]
        public decimal MaxSalary { get; set; }

        // ---- Additional Info ----
        [StringLength(50)]
        [Display(Name = "Job Level (e.g., Entry, Mid, Senior)")]
        public string? Level { get; set; } // nullable string

        [Range(0, 50)]
        [Display(Name = "Required Years of Experience")]
        public int YearsOfExperience { get; set; }

        // ---- Relationships ----
        [Display(Name = "Candidates in this Job Title")]
        public List<Candidate> Candidates { get; set; } = new();

        [Display(Name = "Companies Hiring for this Job Title")]
        public List<Company> Companies { get; set; } = new();
    }
}

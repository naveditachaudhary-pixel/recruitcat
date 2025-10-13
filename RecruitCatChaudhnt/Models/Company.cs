using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecruitCatChaudhnt.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; } // Primary Key

        // ---- Basic Info ----
        [Required]
        [StringLength(100)]
        [Display(Name = "Company Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "Position Name")]
        public string PositionName { get; set; } = string.Empty;

        // ---- Salary Info ----
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Maximum Salary")]
        public decimal MaxSalary { get; set; }

        // ---- Recruiting Info ----
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; } // optional

        [Required]
        [StringLength(250)]
        [Display(Name = "Location (Address)")]
        public string Location { get; set; } = string.Empty;

        // ---- Additional Properties ----
        [Range(1, int.MaxValue)]
        [Display(Name = "Number of Employees")]
        public int NumEmployees { get; set; }

        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Annual Revenue")]
        public decimal Revenue { get; set; }

        [Display(Name = "Remote Friendly")]
        public bool IsRemoteFriendly { get; set; }

        // ---- Relationships ----
        [Display(Name = "Industry")]
        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }

        [Display(Name = "Job Title")]
        public int? JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }

        // ✅ NEW — Navigation property for related candidates (Task 9)
        public List<Candidate> Candidates { get; set; } = new();
    }
}

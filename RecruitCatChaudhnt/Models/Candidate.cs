using System;

namespace RecruitCatChaudhnt.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }  // PK

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }  // optional start date

        // Additional properties
        public DateTime DateOfBirth { get; set; } // datetime
        public string? Email { get; set; }        // nullable string
        public string? Phone { get; set; }
        public bool IsCurrentlyEmployed { get; set; }

        // Relationships
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public int? JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }

        // ✅ NEW: Industry relationship
        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }
    }
}

using System;

namespace RecruitCatChaudhnt.Models
{
    public class Company
    {
        public int CompanyId { get; set; }  // PK

        public required string Name { get; set; }

        // Recruiting for one position at a time
        public required string PositionName { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateTime? StartDate { get; set; }  // optional
        public required string Location { get; set; }

        // Additional properties
        public int NumEmployees { get; set; }     // int
        public decimal Revenue { get; set; }      // decimal
        public bool IsRemoteFriendly { get; set; } // bool

        // Relationships
        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }

        public int? JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
    }
}

using System.Collections.Generic;

namespace RecruitCatChaudhnt.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }  // PK

        public required string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        // Additional properties
        public string? Level { get; set; }        // e.g., Entry, Mid, Senior
        public int YearsOfExperience { get; set; } // int

        // Navigation
        public List<Candidate> Candidates { get; set; } = new();
        public List<Company> Companies { get; set; } = new();
    }
}

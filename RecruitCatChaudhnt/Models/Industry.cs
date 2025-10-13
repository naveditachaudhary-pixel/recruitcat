using System.Collections.Generic;

namespace RecruitCatChaudhnt.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }  // PK

        public required string Name { get; set; }

        // Additional properties
        public string? Description { get; set; }   // nullable string
        public bool IsGrowing { get; set; }        // bool

        // Navigation
        public List<Company> Companies { get; set; } = new();
    }
}

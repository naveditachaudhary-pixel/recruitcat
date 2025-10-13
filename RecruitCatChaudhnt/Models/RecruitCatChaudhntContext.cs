using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RecruitCatChaudhnt.Models
{
    public class RecruitCatChaudhntContext : DbContext
    {
        public RecruitCatChaudhntContext(DbContextOptions<RecruitCatChaudhntContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; } = default!;
        public DbSet<Company> Companies { get; set; } = default!;
        public DbSet<JobTitle> JobTitles { get; set; } = default!;
        public DbSet<Industry> Industries { get; set; } = default!;
    }
}

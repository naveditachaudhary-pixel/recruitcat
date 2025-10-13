using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatChaudhnt.Models;

namespace RecruitCatChaudhnt.Pages.candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatChaudhntContext _context;

        public IndexModel(RecruitCatChaudhntContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidates
                .Include(c => c.Company)   // ✅ Loads company name
                .Include(c => c.JobTitle)  // ✅ Loads job title name
                .Include(c => c.Industry)  // ✅ Loads industry name
                .ToListAsync();
        }
    }
}

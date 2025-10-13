using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatChaudhnt.Models;

namespace RecruitCatChaudhnt.Pages.candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatChaudhntContext _context;

        public DetailsModel(RecruitCatChaudhntContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidates
                .Include(c => c.Company)   // ✅ load related Company
                .Include(c => c.JobTitle)  // ✅ load related Job Title
                .Include(c => c.Industry)  // ✅ load related Industry (if applicable)
                .FirstOrDefaultAsync(m => m.CandidateId == id);

            if (Candidate == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

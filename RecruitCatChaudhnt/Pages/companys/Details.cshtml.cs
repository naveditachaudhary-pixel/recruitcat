using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatChaudhnt.Models;

namespace RecruitCatChaudhnt.Pages.companys
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatChaudhntContext _context;

        public DetailsModel(RecruitCatChaudhntContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Companies
                .Include(c => c.Industry)      // ✅ include related industry
                .Include(c => c.JobTitle)      // ✅ include job title
                .Include(c => c.Candidates)    // ✅ include list of candidates
                .FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

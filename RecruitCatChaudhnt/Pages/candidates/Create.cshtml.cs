using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatChaudhnt.Models;

namespace RecruitCatChaudhnt.Pages.candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatChaudhnt.Models.RecruitCatChaudhntContext _context;

        public CreateModel(RecruitCatChaudhnt.Models.RecruitCatChaudhntContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "CompanyId");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitles, "JobTitleId", "JobTitleId");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidates.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

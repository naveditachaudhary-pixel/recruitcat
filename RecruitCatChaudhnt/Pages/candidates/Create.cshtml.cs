using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatChaudhnt.Models;

namespace RecruitCatChaudhnt.Pages.candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatChaudhntContext _context;

        public CreateModel(RecruitCatChaudhntContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "Name");
            ViewData["JobTitleId"] = new SelectList(_context.JobTitles, "JobTitleId", "Title");
            ViewData["IndustryId"] = new SelectList(_context.Industries, "IndustryId", "Name");

            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["CompanyId"] = new SelectList(_context.Companies, "CompanyId", "Name");
                ViewData["JobTitleId"] = new SelectList(_context.JobTitles, "JobTitleId", "Title");
                ViewData["IndustryId"] = new SelectList(_context.Industries, "IndustryId", "Name");
                return Page();
            }

            _context.Candidates.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

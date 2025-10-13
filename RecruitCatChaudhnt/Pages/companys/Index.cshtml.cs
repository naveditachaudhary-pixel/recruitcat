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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatChaudhnt.Models.RecruitCatChaudhntContext _context;

        public IndexModel(RecruitCatChaudhnt.Models.RecruitCatChaudhntContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Company = await _context.Companies
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}

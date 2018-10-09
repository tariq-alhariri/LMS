using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LMS.Models;

namespace LMS.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly LMS.Models.LMSContext _context;

        public DetailsModel(LMS.Models.LMSContext context)
        {
            _context = context;
        }

        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Author.FirstOrDefaultAsync(m => m.AuthorId == id);

            if (Author == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

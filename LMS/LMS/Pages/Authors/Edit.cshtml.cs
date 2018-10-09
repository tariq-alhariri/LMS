using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LMS.Models;

namespace LMS.Pages.Authors
{
    public class EditModel : PageModel
    {
        private readonly LMS.Models.LMSContext _context;

        public EditModel(LMS.Models.LMSContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(Author.AuthorId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AuthorExists(Guid id)
        {
            return _context.Author.Any(e => e.AuthorId == id);
        }
    }
}

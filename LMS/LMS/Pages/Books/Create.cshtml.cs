using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LMS.Models;

namespace LMS.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly LMS.Models.LMSContext _context;

        public CreateModel(LMS.Models.LMSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "DisplayedName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //Book.author = _context.Author.Where(a => a.AuthorId == Book.AuthorId).FirstOrDefault();
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LMS.Models;

namespace LMS.Pages.Authors
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
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                _context.Author.Add(Author);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return RedirectToPage("../Error");
            }
            //_context.Author.Add(Author);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
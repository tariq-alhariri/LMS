﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LMS.Models;

namespace LMS.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly LMS.Models.LMSContext _context;

        public DetailsModel(LMS.Models.LMSContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.author).FirstOrDefaultAsync(m => m.BookId == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

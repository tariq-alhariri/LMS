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
    public class IndexModel : PageModel
    {
        private readonly LMS.Models.LMSContext _context;

        public IndexModel(LMS.Models.LMSContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.author).ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMS.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly LMS.Models.LMSContext _context;

        public IndexModel(LMS.Models.LMSContext context)
        {
            _context = context;
        }




        public IList<Author> Author { get;set; }
        public SelectList Gender { get; set; }
        public string AuthorGender { get; set; }

        public async Task OnGetAsync(string authorGender, string searchString)
        {
            ////Author = await _context.Author.ToListAsync();
            //var authors = from a in _context.Author
            //             select a;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    authors = authors.Where(a => 
            //    a.FirstName.Contains(searchString) ||
            //    a.LastName.Contains(searchString) ||
            //    a.DisplayedName.Contains(searchString) ||
            //    a.Email.Contains(searchString) ||
            //    a.Mobile.Contains(searchString));
            //}

            //Author = await authors.ToListAsync();


            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from a in _context.Author
                                            orderby a.Gender
                                            select a.Gender;

            var authors = from a in _context.Author
                         select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                authors = authors.Where(a =>
                a.FirstName.Contains(searchString) ||
                a.LastName.Contains(searchString) ||
                a.DisplayedName.Contains(searchString) ||
                a.Email.Contains(searchString) ||
                a.Mobile.Contains(searchString));
            }

                if (!String.IsNullOrEmpty(authorGender))
            {
                authors = authors.Where(a => a.Gender == authorGender);
            }
            Gender = new SelectList(await genreQuery.Distinct().ToListAsync());
            Author = await authors.ToListAsync();
        }
    }
}

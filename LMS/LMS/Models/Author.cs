using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string DisplayedName { get; set; }
    }
}

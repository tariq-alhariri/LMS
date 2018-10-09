using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }


        [MaxLength(50)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [MaxLength(50)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(15)]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number ")]
        public string Mobile { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(15)]
        [Required]
        public string Gender { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Prefered Name")]
        public string DisplayedName { get; set; }

        // relations 
        public ICollection<Book> Books { get; set; }
    }
}

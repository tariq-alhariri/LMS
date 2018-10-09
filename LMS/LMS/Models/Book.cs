using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Book
    {

        // attributes 

        [Key]
        public Guid BookId { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Book Genre")]
        public string Genre { get; set; }

        [DataType(DataType.Duration)]
        [Required]
        [Display(Name = "Nunber Of Pages")]
        public int NumberOfPages { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Book Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Number of Copies")]
        public int NumberOfCopies { get; set; }


        // relations
        [Display(Name = "Author")]
        public Guid AuthorId { get; set; }

        [Required]
        public Author author { get; set; }

    }
}

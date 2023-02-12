using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        [Display(Name = "Book Title"), MinLength(2, ErrorMessage = "Minimum length is 2 chars")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        [DataType(DataType.Currency, ErrorMessage = "Enter correct price.")]
        public double Price { get; set; }
    }
}

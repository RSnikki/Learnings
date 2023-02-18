using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPICoreWebAppMVC.Models
{
    public class Book
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Name is Required")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        //[DataType(DataType.Currency, ErrorMessage = "Enter correct price.")]
        public double Price { get; set; }
    }
}

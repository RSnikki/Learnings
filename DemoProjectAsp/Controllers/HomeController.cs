using DemoProjectAsp.Models;
using DemoProjectAsp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectAsp.Controllers
{
   // [Route("[controller]/[action]/{id?}")]
    
    public class HomeController : Controller
    {
        //List<Book> _book;
        IRepository<Book> _repo;
        public HomeController(IRepository<Book> rbook)
        {
            //_book = new List<Book>();
            _repo =  rbook;
           
        }

       
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                Book item = new Book()
                {
                    
                    Title = book.Title,
                    Author = book.Author,
                    Description = book.Description,
                    PublishedDate = book.PublishedDate,
                    Price = book.Price
                };
                _repo.Add(item);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}

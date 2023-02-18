using DemoAPICore.Models;
using DemoAPICore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPICore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        readonly IRepository<Book> _repo;
        public BookController(IRepository<Book> repo)
        {
            _repo = repo;
        }
        // GET: api/<BookController>
        [HttpGet]
        public JsonResult GetBooks()
        {
            return new JsonResult(_repo.GetAll());
             
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public JsonResult GetBook(int id)
        {
            return new JsonResult(_repo.Get(id));
        }

        // POST api/<BookController>
        [HttpPost]
        public JsonResult AddBook([FromBody] Book book1)
        {
            bool status = _repo.Add(book1);
            return new JsonResult(status);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public JsonResult UpdateBook(int id, [FromBody] Book book2)
        {
            bool status = _repo.Edit(id, book2);
            return new JsonResult(status);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{name}")]
        public JsonResult DeleteBook(string name)
        {
            bool status = _repo.Delete(name);
            return new JsonResult(status);
        }
    }
}

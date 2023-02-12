using DemoProjectAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjectAsp.Services
{
    public class MockBookRepository : IRepository<Book>
    {
        List<Book> _books;
        public MockBookRepository()
        {
            _books = new List<Book>() 
            {
               new Book()
               {
                Id = 1,
                Title = "Wings of Fire",
                Description = "Autobiography of APJ Abdul Kalam",
                Author = "Arun Tiwari",
                Price = 399,
                PublishedDate = "1/1/1999"
               },
               new Book()
               {
                Id = 2,
                Title = "Steve Jobs",
                Description = "Autobiography of Steve Jobs",
                Author = "Issacson",
                Price = 499,
                PublishedDate = "1/1/2012"
               }
            };

        }
        public bool Add(Book item)
        {
            try
            {
                Book book = item;
                book.Id = _books.Max(x => x.Id) + 1;
                _books.Add(item);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            return _books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books.ToList();
        }
    }
}

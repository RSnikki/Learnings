using DemoAPICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPICore.Services
{
    public class SqlRepository: IRepository<Book>
    {

        readonly ApiBookStoreDbContext _context;
        public SqlRepository(ApiBookStoreDbContext context)
        {
            _context = context;
        }

        public bool Add(Book item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string name)
        {
            Book fBook = _context.Books
                             .Where(x => x.Title == name)
                             .FirstOrDefault();
            if (fBook != null)
            {
                _context.Books.Remove(fBook);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Edit(int id, Book item)
        {
            Book fBook = _context.Books.Find(id);

            fBook.Title = item.Title;
            fBook.Description = item.Description;
            fBook.Author = item.Author;
            fBook.PublishedDate = item.PublishedDate;
            fBook.Price = item.Price;

            if (fBook != null)
            {
                _context.Books.Update(fBook);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Book Get(int id)
        {
            if (_context.Books.Count(x => x.Id == id) > 0)
            {
                return _context.Books.FirstOrDefault(x => x.Id == id);
            }
            else
                return null;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }
    }
}

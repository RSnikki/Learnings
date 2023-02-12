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

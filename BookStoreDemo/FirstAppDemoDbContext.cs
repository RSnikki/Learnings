using BookStoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreDemo
{
    public class FirstAppDemoDbContext:DbContext
    {
        public DbSet<Book> Book { get; set; }
    }
}
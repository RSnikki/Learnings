using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPICore.Models
{
    public class ApiBookStoreDbContext: DbContext
    {
        public ApiBookStoreDbContext(DbContextOptions<ApiBookStoreDbContext> Options) : base(Options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectsV13;Initial Catalog= ApiBookStoreDB;Integrated Security=True");
            }
        }

        public DbSet<Book> Books { get; set; }

    }
}

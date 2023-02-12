using BookStoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreDemo.AppDBContext
{
    public class AppDBContext: DbContext
    {
        public AppDBContext()
        {
                
        }
        public DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //needed for migration
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog= BookStoreDB;Integrated Security=True;");
                //use this when trying to connect using username and password
                //persist security info=true;user id=xxx; password=xxx;
            }
            base.OnConfiguring(optionsBuilder);
        }


    }
}

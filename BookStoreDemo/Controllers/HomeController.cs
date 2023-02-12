using BookStoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           
            using (var context = new FirstAppDemoDbContext())
            {
                SQLEmployeeData sqlData = new SQLEmployeeData(context);
               // model.Employees = sqlData.GetAll();
            }
            return View();
        }
        public class SQLEmployeeData
        {
            private FirstAppDemoDbContext _context { get; set; }
            public SQLEmployeeData(FirstAppDemoDbContext context)
            {
                _context = context;
            }
            public void Add(Employee emp)
            {
                _context.Add(emp);
                _context.SaveChanges();
            }
            public Employee Get(int ID)
            {
                return _context.Employees.FirstOrDefault(e => e.Id == ID);
            }
            public IEnumerable<Employee> GetAll()
            {
                return _context.Employees.ToList<Employee>();
            }
        }
    }
}

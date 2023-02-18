using DemoAPICoreWebAppMVC.Models;
using DemoAPICoreWebAppMVC.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoAPICoreWebAppMVC.Controllers
{
    public class BookClientController : Controller
    {
        IConfiguration configuration;
        public BookClientController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET: BookClientController
        public ActionResult Index()
        {
            try
            {
                ServiceRepository serviceRepository = new ServiceRepository(configuration);
                HttpResponseMessage response = serviceRepository.GetResponse("api/Product/");
                response.EnsureSuccessStatusCode();
                var result  = response.Content.ReadAsStringAsync().Result;
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(result);
                return View(books);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // GET: BookClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

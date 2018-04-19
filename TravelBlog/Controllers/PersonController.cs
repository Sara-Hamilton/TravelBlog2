using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class PersonController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();

        public IActionResult Index()
        {
            List<Person> model = db.Persons.ToList();
            return View(model);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

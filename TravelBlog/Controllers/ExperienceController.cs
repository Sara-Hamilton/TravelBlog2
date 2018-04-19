using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlog.Controllers
{
    public class ExperienceController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();
        // GET: /<controller>/

        public IActionResult Index()
        {
            List<Experience> model = db.Experiences.ToList();
            return View(model);

        }
        public IActionResult Details(int id)
        {
            Experience thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
            return View(thisExperience);
        }
        public IActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            ViewBag.PersonId = new SelectList(db.Persons, "PersonId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            db.Experiences.Add(experience);
            var persons = Request.Form["PersonId"];
            for (int i = 0; i < persons.Count; i++)
            {
                PersonExperience pe = new PersonExperience();
                pe.PersonId = int.Parse(persons[i]);
                pe.ExperienceId = experience.ExperienceId;
                db.PersonExperiences.Add(pe);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

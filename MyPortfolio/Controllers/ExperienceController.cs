using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext c = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = c.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            c.Experiences.Add(experience);
            c.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = c.Experiences.Find(id);
            c.Experiences.Remove(value);
            c.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = c.Experiences.Find(id);
            
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            c.Experiences.Update(experience);
            c.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}

using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Ekle";
            ViewBag.v2 = "Deneyimlerim";
            ViewBag.v2 = "Deneyim Ekle";
            var values = experienceManager.GetList();
            return View(values);
        }
        
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        //Ekleme
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Ekle";
            ViewBag.v2 = "Deneyimlerim";
            ViewBag.v2 = "Deneyim Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }


        //Silme
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetById(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }

        //Güncelleme
        [HttpGet]
        public IActionResult EditExperience()
        {
            ViewBag.v1 = "Deneyim Ekle";
            ViewBag.v2 = "Deneyimlerim";
            ViewBag.v2 = "Deneyim Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}

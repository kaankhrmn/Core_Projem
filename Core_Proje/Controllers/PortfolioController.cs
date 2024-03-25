using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolioManager portfolioManager =new PortfolioManager(new EfPortfolioDal());

		public IActionResult Index()
		{
			ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi";
            var values = portfolioManager.GetList();
			return View(values);
		}
		//Proje ekleme
		[HttpGet]
		public IActionResult AddPortfolio()
		{
            ViewBag.v1 = "Proje Ekleme";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Ekleme";
            return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			portfolioManager.TAdd(portfolio);
			return RedirectToAction("Index");
		}
	}
}

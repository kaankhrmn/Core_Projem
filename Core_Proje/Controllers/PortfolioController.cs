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
			ViewBag.v1 = "Portfolio Düzenlemesi";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "Portfolio Düzenlemesi";
            var values = portfolioManager.GetList();
			return View(values);
		}
	}
}

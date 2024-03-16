using BussinesLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
	public class PortfolioList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var values = portfolioManager.GetList();
			return View(values);
		}

		PortfolioManager portfolioManager =new PortfolioManager(new EfPortfolioDal());

	}
}

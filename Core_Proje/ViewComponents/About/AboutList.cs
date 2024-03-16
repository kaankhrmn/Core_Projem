using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About
{
	public class AboutList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var values = aboutManager.GetList();
			return View(values);
		}

		AboutManager aboutManager =new AboutManager(new EfAboutDal());
	}
}

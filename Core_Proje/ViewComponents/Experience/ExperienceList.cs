using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
	public class ExperienceList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var values =experienceManager.GetList();
			return View();
		}

		ExperienceManager experienceManager= new ExperienceManager(new EfExperienceDal());

	}
}

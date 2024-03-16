using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var values = skillManager.GetList();
			return View(values);
		}

		SkillManager skillManager= new SkillManager(new EfSkillDal());

	}
}

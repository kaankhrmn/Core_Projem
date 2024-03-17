using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
	public class ContactList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var value = contactManager.GetList();
			return View(value);
		}

		ContactManager contactManager = new ContactManager(new EfContactDal());

	}
}

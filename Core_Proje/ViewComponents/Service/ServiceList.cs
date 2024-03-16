using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var values = serviceManager.GetList();
			return View(values);
		}

		ServiceManager serviceManager =new ServiceManager(new EfServiceDal());

	}
}	

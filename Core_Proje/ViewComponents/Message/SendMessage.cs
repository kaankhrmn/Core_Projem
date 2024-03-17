using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Message
{
	public class SendMessage : ViewComponent
	{
		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}

		//[HttpPost]
		//public IViewComponentResult Invoke(Message p)
		//{
		//	p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesaj kaydedildiği andaki tarih veri tabanına kaydedilsin
		//	p.Status = true; //aktif mesaj anlamında. okunduktan sonra false olacak.
		//	messageManager.TAdd(p);
		//	return View();
		//}



		MessageManager messageManager = new MessageManager(new EfMessageDal());
	}
}

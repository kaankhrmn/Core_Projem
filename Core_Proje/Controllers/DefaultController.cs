using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //bunlar benim oluşturduğum partiallar.
        public PartialViewResult HeadderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }


        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

		[HttpPost]
		public PartialViewResult SendMessage(Message p)
		{
			MessageManager messageManager = new MessageManager(new EfMessageDal());
			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesaj kaydedildiği andaki tarih veri tabanına kaydedilsin
			p.Status = true; //aktif mesaj anlamında. okunduktan sonra false olacak.
			messageManager.TAdd(p);
			return PartialView();
		}
	}
}

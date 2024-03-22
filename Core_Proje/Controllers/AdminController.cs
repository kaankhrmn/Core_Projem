using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
	public class AdminController : Controller
	{
		public PartialViewResult PartialSideBar() //sol menü burda takılacak
		{
			return PartialView();
		}
       
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
    }
}

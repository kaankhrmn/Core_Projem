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
    }
}

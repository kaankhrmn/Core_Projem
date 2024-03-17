using BussinesLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial
{
	public class TestimonialList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var values = testimonialManager.GetList();
			return View(values);
		}
		TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

		 
	}
}

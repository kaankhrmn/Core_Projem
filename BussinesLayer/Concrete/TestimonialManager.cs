using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class TestimonialManager : ITestimonialService
	{
		ITestimonialDal _testimonialService;

		public TestimonialManager(ITestimonialDal testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public List<Testimonial> GetList()
		{
			return _testimonialService.GetList();
		}

		public void TAdd(Testimonial t)
		{
			_testimonialService.Insert(t);
		}

		public void TDelete(Testimonial t)
		{
			_testimonialService.Delete(t);
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialService.GetById(id);
		}

		public void TUpdate(Testimonial t)
		{
			_testimonialService.Update(t);
		}
	}
}

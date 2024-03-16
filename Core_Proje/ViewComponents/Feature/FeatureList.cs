using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var values = FeatureManager.GetList();
            return View(values);
        }

        FeatureManager FeatureManager =new FeatureManager(new EfFeatureDal());
    }
}

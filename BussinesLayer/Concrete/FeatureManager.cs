using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal; 

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}

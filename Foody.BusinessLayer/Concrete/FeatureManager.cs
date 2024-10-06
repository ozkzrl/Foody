using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {

        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Tdelete(int id)
        {
            _featureDal.delete(id);
        }

        public List<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void Tinsert(Feature entity)
        {
            _featureDal.insert(entity);
        }

        public void Tupdate(Feature entity)
        {
            _featureDal.update(entity);
        }
    }
}

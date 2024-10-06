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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Tdelete(int id)
        {
            _socialMediaDal.delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
           return _socialMediaDal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void Tinsert(SocialMedia entity)
        {
            _socialMediaDal.insert(entity);
        }

        public void Tupdate(SocialMedia entity)
        {
            _socialMediaDal.update(entity);
        }
    }
}

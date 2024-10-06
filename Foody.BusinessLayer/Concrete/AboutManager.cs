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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void Tdelete(int id)
        {
            _aboutdal.delete(id);
        }

        public List<About> TGetAll()
        {
            return _aboutdal.GetAll();
        }

        public About TGetById(int id)
        {
            return _aboutdal.GetById(id);
        }

        public void Tinsert(About entity)
        {
            _aboutdal.insert(entity);
        }

        public void Tupdate(About entity)
        {
            _aboutdal.update(entity);
        }
    }
}

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
    public class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void Tdelete(int id)
        {
           _categorydal.delete(id);
        }

        public List<Category> TGetAll()
        {
            return _categorydal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public void Tinsert(Category entity)
        {
            _categorydal.insert(entity);
        }

        public void Tupdate(Category entity)
        {
            _categorydal.update(entity);
        }
    }
}

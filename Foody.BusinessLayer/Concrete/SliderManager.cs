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
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Tdelete(int id)
        {
            _sliderDal.delete(id);
        }

        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void Tinsert(Slider entity)
        {
            _sliderDal.insert(entity);
        }

        public void Tupdate(Slider entity)
        {
            _sliderDal.update(entity);
        }
    }
}

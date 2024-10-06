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
    public class AddressManager : IAddressService
    {

        private readonly IAddressDal _adressdal;

        public AddressManager(IAddressDal adressdal)
        {
            _adressdal = adressdal;
        }

        public void Tdelete(int id)
        {
            _adressdal.delete(id);
        }

        public List<Address> TGetAll()
        {
            return _adressdal.GetAll();
        }

        public Address TGetById(int id)
        {
            return _adressdal.GetById(id);
        }

        public void Tinsert(Address entity)
        {
           _adressdal.insert(entity);
        }

        public void Tupdate(Address entity)
        {
           _adressdal.update(entity);
        }
    }
}

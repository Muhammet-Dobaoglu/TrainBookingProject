using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBookingProject.DataAccessLayer.Abstract;
using TrainBookingProject.EntityLayer.Concrete;

namespace TrainBookingProject.BusinessLayer.Concrete
{
    public class WagonManager
    {
        private readonly IWagonDal _wagonDal;

        public WagonManager(IWagonDal wagonDal)
        {
            _wagonDal = wagonDal;
        }

        public void TDelete(Wagon t)
        {
            _wagonDal.Delete(t);
        }

        public Wagon TGetById(int id)
        {
            return _wagonDal.GetById(id);
        }

        public List<Wagon> TGetList()
        {
            return _wagonDal.GetList();
        }

        public void TInsert(Wagon t)
        {
            _wagonDal.Insert(t);
        }

        public void TUpdate(Wagon t)
        {
            _wagonDal.Update(t);
        }
    }
}
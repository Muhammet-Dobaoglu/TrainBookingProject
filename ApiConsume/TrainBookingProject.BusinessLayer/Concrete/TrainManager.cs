using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBookingProject.BusinessLayer.Abstract;
using TrainBookingProject.DataAccessLayer.Abstract;
using TrainBookingProject.EntityLayer.Concrete;

namespace TrainBookingProject.BusinessLayer.Concrete
{
    public class TrainManager : ITrainService
    {
        private readonly ITrainDal _trainDal;

        public TrainManager(ITrainDal trainDal)
        {
            _trainDal = trainDal;
        }

        public void TDelete(Train t)
        {
            _trainDal.Delete(t);
        }

        public Train TGetById(int id)
        {
           return _trainDal.GetById(id);
        }

        public List<Train> TGetList()
        {
            return _trainDal.GetList();
        }

        public void TInsert(Train t)
        {
            _trainDal.Insert(t);
        }

        public void TUpdate(Train t)
        {
            _trainDal.Update(t);
        }
    }
}

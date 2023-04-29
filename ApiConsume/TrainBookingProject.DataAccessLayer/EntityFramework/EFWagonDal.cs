using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBookingProject.DataAccessLayer.Abstract;
using TrainBookingProject.DataAccessLayer.Concrete;
using TrainBookingProject.DataAccessLayer.Repositories;
using TrainBookingProject.EntityLayer.Concrete;

namespace TrainBookingProject.DataAccessLayer.EntityFramework
{
    public class EFWagonDal : GenericRepository<Wagon>, IWagonDal
    {
        public EFWagonDal(Context context) : base(context)
        {
        }
    }
}

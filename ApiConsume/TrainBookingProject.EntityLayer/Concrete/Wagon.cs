using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBookingProject.EntityLayer.Concrete
{
    public class Wagon
    {
        public int WagonID { get; set; }
        public string WagonName { get; set; }
        public int WagonCapacity { get; set; }
        public int SeatCount { get; set; }
    }
}

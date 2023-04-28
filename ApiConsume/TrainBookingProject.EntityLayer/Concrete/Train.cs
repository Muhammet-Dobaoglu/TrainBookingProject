using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBookingProject.EntityLayer.Concrete
{
    public class Train
    {
        public int TrainID { get; set; }
        public int TrainName { get; set; }
        public int BookingCount { get; set; }
        public bool DifferentCarriage { get; set; }

        public List<Wagon> Wagons { get; set; }
    }
}
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainBookingProject.EntityLayer.Concrete;

namespace TrainBookingProject.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MUHAMMET\\MSSQLSERVER01; initial catalog=DbBookingProject; integrated security=true;");
        }

        public DbSet<Train> Trains { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
    
    }
}

using Microsoft.EntityFrameworkCore;
using ProjektWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SpeciesModel> Species { get; set; }
        public DbSet<PetModel> Pets { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }

    }
}

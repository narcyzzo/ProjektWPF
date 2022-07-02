using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPF.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public decimal Price { get; set; }
        public int? Id_Pet { get; set; }
        public int? Id_Doctor { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPF.Models
{
    public class PetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? Id_Species { get; set; }
        //public SpeciesModel Species { get; set; }

        public string DescriptionString { get { return Name + " (" + DateOfBirth.ToShortDateString() + ")"; } }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class SurgicalHistory
    {
        public int Id { get; set; }
        public string Operation { get; set; }
        public DateTime DateofSurgery { get; set; }

    }
}

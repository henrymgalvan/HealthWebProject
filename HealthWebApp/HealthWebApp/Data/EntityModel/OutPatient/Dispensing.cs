using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class Dispensing
    {
        public int Id { get; set; }
        //Source of Prescription
        public bool Others { get; set; }
        public bool Facility { get; set; }
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }
        public DateTime DispensingDate { get; set; }
        public int DispenseBy { get; set; }

    }
}

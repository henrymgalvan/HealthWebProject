using HealthWebApp.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class ImmunizationRecord
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public int VaccineId { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public DateTime DateReceived { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee AdministeredBy { get; set; }

        public string Notes { get; set; }


    }
}

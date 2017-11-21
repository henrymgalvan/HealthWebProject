using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class Consultation
    {
        public int Id { get; set; }
        public int AdmissionId { get; set; }
        public virtual Admission Admission { get; set; }
        public int VitalStatsId { get; set; }
        public virtual VitalStats NewVitalStats { get; set; }

        public bool Done { get; set; }
        
        public int AttendingPhysicianId { get; set; } // based on PhysicianId

    }
}

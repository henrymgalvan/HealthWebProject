using HealthWebApp.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class Consultation
    {
        public int Id { get; set; }

        public int PersonId { get; set; }
        public virtual Patient Patient { get; set; }

        public virtual Admission Admission { get; set; }

        public virtual VitalStats NewVitalStats { get; set; }

        public virtual PhysicalExam PhysicalExam { get; set; }

        public virtual RiskAssesment RiskAssesment { get; set; }

        public virtual DoctorsOrder DoctorsOrder { get; set; }

        public virtual ConsultationStatus ConsultationStatus { get; set; }


        public bool Done { get; set; }
        

        public int EmployeeId { get; set; } // based on PhysicianId
        public Physician Physician { get; set; }
    }
}

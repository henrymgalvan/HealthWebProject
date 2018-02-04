using HealthWebApp.Data.EntityModel.OutPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.Laboratory.Imaging
{
    public class Ultrasound
    {
        public long Id { get; set; }

        public long PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public string Findings { get; set; }
        public string Impression { get; set; }

    }
}

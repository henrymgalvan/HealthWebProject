using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class RiskAssesment
    {
        public int Id { get; set; }

        public int ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }
    }
}

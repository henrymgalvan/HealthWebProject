using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public class ConsultationStatus
    {
        public int Id { get; set; }
        //link to Consultation

        //Consultation Status : Completed, Incomplete
        public bool Completed { get; set; }
        public bool Incomplete { get; set; }
        public DateTime DateOfFollowUp { get; set; }

        //Follow-up Remarks
        public string FollowUpRemarks { get; set; }

    }
}

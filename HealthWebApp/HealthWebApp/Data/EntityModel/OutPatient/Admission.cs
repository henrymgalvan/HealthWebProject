using HealthWebApp.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public enum NatureOfVisit
    {
        NewConsultation = 1, FollowUpVisit = 2
    }
    public enum ModeOfTransaction
    {
        Referral = 1, Visited = 2, WalkIn = 3
    }
    public class Admission
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public DateTime Date { get; set; }      //Default to Current Date & Time
        public int AgeInYears { get; set; }     //computed
        public int AgeInMonths { get; set; }    //computed
        public int AgeInDays { get; set; }      //computed

        public NatureOfVisit NatureOfVisit { get; set; }
        public ModeOfTransaction Transaction { get; set; }
        public PurposeOfVisit PurposeOfVisit { get; set; }
        public string ChiefComplaint { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee AdmittedBy { get; set; } //Baded On LogIn



    }
}

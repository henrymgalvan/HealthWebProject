using HealthWebApp.Data.EntityModel.PhilHealthFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public enum BloodTypeEnum { A = 1, B = 2, AB = 3, O = 4 }
    public enum RhDEnum{ Negative = 1, Positive = 2 }

    public class Patient : Person
    {
        public BloodTypeEnum BloodType { get; set; }
        public RhDEnum RhDType { get; set; }

        public ChildBirthRecord BirthRecord { get; set; }

        public FamilyHistory FamilyHistory { get; set; }
        public MedicalHistory MedicalHistory { get; set; }
        public IEnumerable<MedicalHistoryPresentIllness> Presentillnesses { get; set; }
        public PersonalSocialHistory SocialHistory { get; set; }
        public SurgicalHistory SurgicalHistory { get; set; }

        public ImmunizationRecord ImmunizationRecord { get; set; }
        public IEnumerable<Consultation> Consultations { get; set; }



    }
}

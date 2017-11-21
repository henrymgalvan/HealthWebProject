
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public enum Disposition
    {
        Absconded = 1, Admission = 2, HomeAgainstMedicalAdvice = 3, SentHome = 4, Referred = 5
    }
    public enum ConditionOfDischarge
    {
        Good = 1, Satisfactory = 2, Serious = 3, Critical = 4, Espired = 5
    }

    public class DoctorsOrder //pg109
    {
        public int Id { get; set; }
        //Laboratory Request
        //Imaging
        //Alert Type
        //Alert Description
        //Type Of Diagnosis Admitting, Final, Working, Not Applicable
        //For Final Diagnosis - specify ICD10 code
        public Disposition Disposition { get; set; }
        public ConditionOfDischarge ConditionOfDischarge { get; set; }

        public string  Remarks { get; set; }

    }
}

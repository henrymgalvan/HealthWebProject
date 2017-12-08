
using HealthWebApp.Data.EntityModel.OutPatient.ICD;
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
    public enum TypeOfDiagnosis
    {
        Admitting =1, Final = 2, Working = 3, NotApplicable = 4
    }


    public class DoctorsOrder //pg109
    {
        public int Id { get; set; }
        //Laboratory Request
        public bool BloodChemistry { get; set; }
        public bool CompleteBloodCount { get; set; }
        public bool ClinicalChemistry { get; set; }
        public bool Fecalysis { get; set; }
        public bool Hematology { get; set; }
        public bool Immunology { get; set; }
        public bool Serology { get; set; }
        public bool SputumMicroscopy { get; set; }
        public bool Urinalysis { get; set; }

        //Imaging
        public bool ECG { get; set; }
        public bool MRI { get; set; }
        public bool Ultrasound { get; set; }
        public bool XRay { get; set; }

        //Alert Type
        public bool Allergy { get; set; }
        public bool Disability { get; set; }
        public bool Drug { get; set; }
        public bool Handicap { get; set; }
        public bool Impairment { get; set; }
        public bool OtherAlertType { get; set; }
        //Alert Description
        public string AlertDescription { get; set; }

        //Type Of Diagnosis Admitting, Final, Working, Not Applicable
        public TypeOfDiagnosis DiagnosisType { get; set; }
        public ICD10 Icd10 { get; set; } //List of ICD10 code
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public Disposition Disposition { get; set; }
        public ConditionOfDischarge ConditionOfDischarge { get; set; }
        public DateTime DateOfDischarge { get; set; }
        public string Remarks { get; set; }


        //For follow-up
        public bool ScheduleNextVisit { get; set; }
        public DateTime ScheduleOfNextVisit { get; set; }

        //Prescribe Medicine

//        public TypeOfConsultationService ConsultationService { get; set; }

    }
}

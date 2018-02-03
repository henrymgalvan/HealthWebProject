using HealthWebApp.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public enum BMI
    {
        Normal = 1, Overweight = 2
    }
    public enum BPMeasurementAssesment
    {
        Hypertensive = 1, NonHypertensive = 2  //select BP Measurement assesment
    }
    public enum WeightCategoryForAge
    {
        Normal = 1
    }
    public enum HeightCategoryForAge
    {
        Normal = 1
    }

    public class VitalStats
    {
        public long Id { get; set; }

        public long ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }

        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public BPMeasurementAssesment BPAssesment { get; set; }

        public int PulseRate { get; set; }
        public int RespiratoryRate { get; set; }
        public int HeartRate { get; set; }
        public bool NormalRate { get; set; }    //yes or no
        public bool RegularRhythm { get; set; } //yes or no
        
        public decimal TemperatureC { get; set; }
        public decimal WeightKgms { get; set; }     //in viewmodel add weightInPounds
        public WeightCategoryForAge WeightCategory{ get; set; }
        public decimal HeightCm { get; set; }       //in viewmodel add Height in feet and inches
        public HeightCategoryForAge HeightCategory { get; set; }
        public decimal WaistCircumferenceCm { get; set; }   //in viewmodel add waistcircumference in inches
        public BMI BodyMassIndex { get; set; }        //Computed

        public string Remarks { get; set; }

        public long EmployeeId { get; set; }
        public virtual Employee AdministeredBy { get; set; } //Baded On LogIn
    }
}

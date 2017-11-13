using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public enum BMI
    {
        Normal = 1, Overweight = 2
    }
    public enum BPMeasurementAssesment
    {
        Hypertensive = 1, NonHypertensive = 2
    }
    public class VitalStats
    {
        public int Id { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public BPMeasurementAssesment BPAssesment { get; set; }

        public int PulseRate { get; set; }
        public int RespiratoryRate { get; set; }
        public int HeartRate { get; set; }
        public bool NormalRate { get; set; }
        public bool RegularRhythm { get; set; }
        
        public decimal TemperatureC { get; set; }
        public decimal WeightKgms { get; set; }
        public decimal HeightCm { get; set; }
        public decimal WaistCircumferenceCm { get; set; }
        public BMI BodyMassIndex { get; set; }        //Computed

        public string Remarks { get; set; }


    }
}

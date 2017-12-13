using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
    public enum FrequencyLookUp
    {
        Daily = 1, Weekly = 2, Monthly = 3, Quarterly = 4, Yearly = 5, Indifinite = 6
    }
    public enum DoseRegimenLookUp
    {
        OnceADay = 1, TwiceADay = 2, ThriceADay = 3, FourTimesADay = 4, Every4Hours = 5, EveryMorning = 6, EveryEvening = 7, Others = 8
    }

    public class Prescription
    {
        public int Id { get; set; }
        //consultation id
        public string DrugCode { get; set; }
        public FrequencyLookUp Frequency { get; set; }
        public DoseRegimenLookUp doseRegimen { get; set; }
        public int TotalQuantity { get; set; }
        public string QuantityUnitOfMeasure { get; set; }
        public string IntededPurposeOfMedicine { get; set; }
        public string Medication { get; set; }
        public DateTime DateOfPrescription { get; set; }
        public int PrescribedBy { get; set; }


    }
}

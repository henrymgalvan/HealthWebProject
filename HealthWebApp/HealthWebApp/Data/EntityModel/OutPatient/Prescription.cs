using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.OutPatient
{
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.Medicines
{
    public enum UnitType
    {
        Tablet = 1, Capsule = 2, Bottle = 3 
    }
    public class MedicineInventory
    {

        //Inventory Drugs, All Drugs
        public int Id { get; set; }
        public string DrugCode { get; set; }
        public string DrugDescription { get; set; }
        public UnitType Unit { get; set; }
        public int OnStock { get; set; }

    }
}

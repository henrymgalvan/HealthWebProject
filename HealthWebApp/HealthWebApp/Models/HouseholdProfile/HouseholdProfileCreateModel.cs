using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.HouseholdProfile
{
    public class HouseholdProfileCreateModel
    {
        public int Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public int BarangayId { get; set; }
        public string Note { get; set; }
    }
}

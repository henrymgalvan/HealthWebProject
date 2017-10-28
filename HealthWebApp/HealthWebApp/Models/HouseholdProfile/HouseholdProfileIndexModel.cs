using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.HouseholdProfile
{
    public class HouseholdProfileIndexModel
    {
        public IEnumerable<HouseholdProfileDetailModel> Households { get; set; }
    }
}

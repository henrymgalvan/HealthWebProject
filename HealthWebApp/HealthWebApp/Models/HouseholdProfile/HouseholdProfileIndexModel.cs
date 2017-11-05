using System.Collections.Generic;
 
namespace HealthWebApp.Models.HouseholdProfile
{
    public class HouseholdProfileIndexModel
    {
        public IEnumerable<HouseholdProfileDetailModel> Households { get; set; }
    }
}

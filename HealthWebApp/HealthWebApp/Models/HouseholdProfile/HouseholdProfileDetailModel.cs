using HealthWebApp.Models.HouseholdMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.HouseholdProfile
{
    public class HouseholdProfileDetailModel
    {
        public long Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public string Barangay { get; set; }
        public string Note { get; set; }
        public IEnumerable<HouseholdMemberDetailModel> HouseholdMembers { get; set; }
    }
}

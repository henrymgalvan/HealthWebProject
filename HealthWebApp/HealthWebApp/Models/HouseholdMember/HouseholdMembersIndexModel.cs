using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.HouseholdMember
{
    public class HouseholdMembersIndexModel
    {
        public IEnumerable<HouseholdMemberDetailModel> Members { get; set; }
    }
}

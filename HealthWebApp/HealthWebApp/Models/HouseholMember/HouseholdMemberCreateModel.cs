using HealthWebApp.Data.EntityModel.Household;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.HouseholMember
{
    public class HouseholdMemberCreateModel
    {
        public long PersonId { get; set; }
        public long HouseholdProfileId { get; set; }
        public RelationToHouseholdHead RelationToHouseholdHead { get; set; }
    }
}

using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.EntityModel.Household;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Models.HouseholdMember
{
    public class HouseholdMemberCreateModel
    {
        public long PersonId { get; set; }
        public long HouseholdProfileId { get; set; }
        public RelationToHouseholdHead RelationToHouseholdHead { get; set; }
    }
}

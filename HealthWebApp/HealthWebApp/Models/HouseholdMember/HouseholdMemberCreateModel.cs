using HealthWebApp.Data.EntityModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Models.HouseholdMember
{
    public class HouseholdMemberCreateModel
    {
        public int PersonId { get; set; }
        public int HouseholdProfileId { get; set; }
        public RelationToHouseholdHead RelationToHouseholdHead { get; set; }
    }
}

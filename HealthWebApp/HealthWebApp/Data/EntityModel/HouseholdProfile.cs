using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel
{
    public class HouseholdProfile
    {
        [Key]
        public int Id { get; set; }
        public string ProfileId { get; set; }

        public string Address { get; set; }
        public int BarangayId { get; set; }
        public virtual Barangay Barangay {get; set;}

        //public virtual Person Respondent {get; set;}
        public int RespondentId { get; set; } //member of family

        public virtual IEnumerable<HouseholdMember> HouseholdMembers { get; set; }
        public string Note { get; set; }
    }
}
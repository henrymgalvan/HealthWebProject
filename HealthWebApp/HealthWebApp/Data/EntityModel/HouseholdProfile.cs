using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel
{
    public class HouseholdProfile
    {
        public int Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        
        public int BarangayId { get; set; } 
        public int RespondentId { get; set; } //member of family

        public string Note { get; set; }

        public virtual Barangay Barangay {get; set;}
        public virtual Person Respondent {get; set;}



    }
}
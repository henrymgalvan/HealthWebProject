using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel
{

    public enum RelationToHouseholdHead
     { 
        Head = 1, Spouse = 2, Son = 3, Daughter = 4, Grandson = 5, GrandDaughter = 6,
        DaughterInLaw = 7, SonInLaw = 8, FatherInLaw = 9, MotherInLaw = 10,
        Father = 11, Mother = 12, Brother = 13, Sister = 14,
        Guest = 15
     }
    public class HouseholdMember
    {
        [Key]
        public int Id { get; set; }

        public RelationToHouseholdHead RelationToHead { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public int HouseholdProfileId { get; set; }
        public virtual HouseholdProfile HouseholdProfile { get; set; }

    }
}
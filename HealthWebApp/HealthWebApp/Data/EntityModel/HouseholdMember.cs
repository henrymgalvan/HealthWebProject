namespace HealthWebApp.Data.EntityModel
{
    public enum CivilStatus
    {
        Dependent = 1, Single, Married, LiveIn ,Separated, Annuled, Widowed
    }
    public enum RelationToHouseholdHead
     { 
        Head = 1, Spouse = 2, Son = 3, Daughter = 4, Grandson = 5, GrandDaughter = 6,
        DaughterInLaw = 7, SonInLaw = 8, FatherInLaw = 9, MotherInLaw = 10,
        Father = 11, Mother = 12, Brother = 13, Sister = 14,
        Guest = 15
     }
    public class HouseholdMember
    {
        public int Id { get; set; }
        public string HouseholdProfileId { get; set; }
        public int PersonId { get; set; }
        public RelationToHouseholdHead RelationToHead { get; set; }

        public int FatherId { get; set; }
        public int MotherId { get; set; }

        public CivilStatus CivilStatus { get; set; }
        public virtual Person Person { get; set; }

    }
}
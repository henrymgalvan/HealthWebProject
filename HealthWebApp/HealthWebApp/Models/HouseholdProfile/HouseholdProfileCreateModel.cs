namespace HealthWebApp.Models.HouseholdProfile
{
    public class HouseholdProfileCreateModel
    {
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public int BarangayId { get; set; }
        public string Note { get; set; }
    }
}

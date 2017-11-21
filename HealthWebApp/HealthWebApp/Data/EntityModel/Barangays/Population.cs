namespace HealthWebApp.Data.EntityModel.Barangays
{
    public class Population
    {
        public int Id { get; set; }
        public int BarangayId { get; set; }
        public int Year { get; set; }
        public int Total { get; set; }
        public int NoOfHousehold { get; set; }
        public int NoOfFamilies { get; set; }
    }
}
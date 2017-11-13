using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.EntityModel
{
    public class BarangayOfficial
    {
        public int Id { get; set; }
        public int BarangayId { get; set; }
        public virtual Barangay Barangay { get; set; }
        public int PersonId { get; set; }
        public virtual Person Officer { get; set; }
        public int DesignationId { get; set; }
        public virtual Designation Position { get; set; }
    }
}
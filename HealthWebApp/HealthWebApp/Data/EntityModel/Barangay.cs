using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel
{
    public class Barangay
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
using System.Collections.Generic;

namespace HealthWebApp.Data.EntityModel
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        
        public virtual ICollection<Employee> Staffs { get; set; }
    }
}
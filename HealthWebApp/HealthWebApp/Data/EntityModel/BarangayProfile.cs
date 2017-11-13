
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public class BarangayProfile
    {
        public int Id { get; set; }
        public int BarangayId { get; set; }
        public virtual Barangay Barangay { get; set; }

        public IEnumerable<Person> BarangayOfficials { get; set; }
        public virtual IEnumerable<Population> Population { get; set; }
        public int NoOfHousehold { get; set; }
        public int NoOfFamilies { get; set; }

        public virtual IEnumerable<Employee> BarangayNurses { get; set; }
        public virtual IEnumerable<Employee> BarangayHealthWorkers { get; set; }
        public virtual IEnumerable<Employee> BarangayPhysicians { get; set; }

    }
}

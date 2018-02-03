using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel.Barangays
{
    public class Barangay
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        public int CityMunicipalityId { get; set; }
        public virtual CityMunicipality CityMunicipality { get; set; }

        public IEnumerable<BarangayOfficial> BarangayOfficials { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.Barangays
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public IEnumerable<CityMunicipality> CityMunicipalities { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.Admin
{
    public class DriverLicenseID
    {
        public long Id { get; set; }
        public string DriverLicenseId { get; set; }
        public DateTime Expiration { get; set; }

    }
}

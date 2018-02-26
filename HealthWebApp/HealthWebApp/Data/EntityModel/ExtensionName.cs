using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public class ExtensionName
    {
        public int Id { get; set; }
        public string ShortExtension { get; set; }
        public string LongExtension { get; set; }

        public long EmployeeId { get; set; }
    }
}

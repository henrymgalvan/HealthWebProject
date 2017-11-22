using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public class FemaleMarriedPerson
    {
        [Key]
        public int PersonId { get; set; }
        public string MaidenMiddleName { get; set; }
        public string MaidenLastName { get; set; }

        public virtual Person Person { get; set; }



    }
}

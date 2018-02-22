using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public class Family
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public virtual Person Person { get; set; }

        public long FatherId { get; set; }
        public virtual Person Father { get; set; }
        public long MotherId { get; set; }
        public virtual Person Mother { get; set; }

        public long SpouseId { get; set; }
        public virtual Person Spouse { get; set; }

        public virtual ICollection<Person> Children { get; set; }
        public virtual ICollection<Person> Siblings { get; set; }
    }
}

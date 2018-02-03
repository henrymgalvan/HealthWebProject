using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel
{
    public class Family
    {
        [Key]
        public long Id { get; set; }
        public long PersonId { get; set; }

        public long FatherId { get; set; }
        public long MotherId { get; set; }

        public long Spouse { get; set; }
        IEnumerable<Person> Children { get; set; }
        IEnumerable<Person> Siblings { get; set; }
    }
}

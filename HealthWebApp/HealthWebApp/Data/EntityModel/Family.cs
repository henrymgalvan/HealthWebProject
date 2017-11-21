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
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int FatherId { get; set; }
        public int MotherId { get; set; }

        public int Spouse { get; set; }
        IEnumerable<Person> Children { get; set; }
        IEnumerable<Person> Siblings { get; set; }
    }
}

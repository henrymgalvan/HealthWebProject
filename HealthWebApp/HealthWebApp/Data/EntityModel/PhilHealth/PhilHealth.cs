using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.PhilHealth
{
    public enum StatusType
    {
        Member = 1, Dependent = 2
    }
    public class PhilHealth
    {
        public int Id { get; set; }
        public string Identification { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public StatusType StatusType { get; set; }
        public PhilHealthCategory Category { get; set; }
        public DateTime DateAssigned { get; set; }


    }
}

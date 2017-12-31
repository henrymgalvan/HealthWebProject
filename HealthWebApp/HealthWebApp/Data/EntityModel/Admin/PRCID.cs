using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.Admin
{
    public class PRCID
    {
        public int Id { get; set; }
        public string PRCId { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateOfExpiration { get; set; }


    }
}

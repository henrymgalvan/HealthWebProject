using System;

namespace HealthWebApp.Data.EntityModel.Admin
{
    public class EmploymentRecord
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EmployeeIdentification { get; set; }
        //public int SectionId { get; set; }
        public Position Position { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public EmploymentStatus Status { get; set; }


        public String Notes { get; set; }

    }
}
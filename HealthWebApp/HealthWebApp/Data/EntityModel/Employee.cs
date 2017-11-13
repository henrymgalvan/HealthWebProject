using System.Collections.Generic;

namespace HealthWebApp.Data.EntityModel
{
    public enum EmploymentStatus
    {
        Regular = 1, JOE = 2, EOC = 3, Terminated = 4
    }
    public class Employee
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public string EmployeeIdentification { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public int SectionId { get; set; }
        public virtual Section Section { get; set; }

        public virtual IEnumerable<Barangay> AreaOfAssignments { get; set; }
        
        public EmploymentStatus EmployeeStatus { get; set; }
        public bool ActiveInService { get; set; }

        public string PRCID { get; set; }

        public virtual IEnumerable<EmploymentRecord> EmployeeRecords { get; set; }

        public string Note { get; set; }

    }
}

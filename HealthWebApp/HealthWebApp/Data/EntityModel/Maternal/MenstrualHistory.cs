using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.EntityModel.Maternal
{
    public enum BirthControlMethod { NaturalMethod = 1, Pills = 2, Injectable = 3, BLT = 4 }

    public class MenstrualHistory
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public DateTime LastMenstrualPeriod { get; set; }
        public string PeriodDuration { get; set; }
        public string IntervalCycle { get; set; }
        public int NoOfPadsPerDayDuringMenstruation { get; set; }
        public BirthControlMethod BirthControlMethod { get; set; }

        public string Notes { get; set; }

    }
}

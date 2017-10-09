using HealthWebApp.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.Interface
{
    public interface IHouseholdMember
    {
        IEnumerable<HouseholdMember> GetAll();
        HouseholdMember Get(int PersonId);
        void Add(HouseholdMember newHouseholdMember);
    }
}

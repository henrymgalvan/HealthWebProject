using HealthWebApp.Data.EntityModel;
using System.Collections.Generic;

namespace HealthWebApp.Data.Interface
{
    public interface IHouseholdProfile
    {
        IEnumerable<HouseholdProfile> GetAll();
        HouseholdProfile Get(int id);
        HouseholdProfile Get(string ProfileId);
        void Add(HouseholdProfile newHouseholdProfile);

    }
}

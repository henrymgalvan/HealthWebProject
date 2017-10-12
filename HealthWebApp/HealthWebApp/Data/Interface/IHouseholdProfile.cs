using HealthWebApp.Data.EntityModel;
using System.Collections.Generic;

namespace HealthWebApp.Data.Interface
{
    public interface IHouseholdProfile
    {
        IEnumerable<HouseholdProfile> GetAll();
        HouseholdProfile GetById(int id);
        HouseholdProfile GetByProfileId(string ProfileId);
        void Add(HouseholdProfile newHouseholdProfile);

    }
}

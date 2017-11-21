using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.EntityModel.Household;
using System.Collections.Generic;

namespace HealthWebApp.Data.Interface
{
    public interface IHouseholdProfile
    {
        IEnumerable<HouseholdProfile> GetAll();
        IEnumerable<HouseholdProfile> GetallByBarangay(int BarangayId);

        HouseholdProfile GetByPersonId(int PersonId);
        HouseholdProfile GetById(int id);
        HouseholdProfile GetByProfileId(string ProfileId);

        void Add(HouseholdProfile newHouseholdProfile);
        void Update(HouseholdProfile updatedHouseholdProfile);

    }
}

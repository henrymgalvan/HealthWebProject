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
        IEnumerable<HouseholdMember> GetAllByHouseholdProfileId(int householdProfileId);
        HouseholdMember Get(int Id);
        Person GetMemberDetail(int PersonId);
        Person GetFather(int FatherId);
        Person GetMother(int MotherId);
        void Add(HouseholdMember newHouseholdMember);
        void Delete(int HouseholdMemberId);
    }
}

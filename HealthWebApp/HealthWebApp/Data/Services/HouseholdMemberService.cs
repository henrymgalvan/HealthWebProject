using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using System.Linq;

namespace HealthWebApp.Data.Services
{
    public class HouseholdMemberService : IHouseholdMember
    {
        private ApplicationDbContext _context;
        public HouseholdMemberService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(HouseholdMember newHouseholdMember)
        {
            _context.Add(newHouseholdMember);
            _context.SaveChanges();
        }

        public void Delete(int HouseholdMemberId)
        {
            HouseholdMember householdMember = _context.HouseholdMember.FirstOrDefault(p => p.Id == HouseholdMemberId);
            _context.HouseholdMember.Remove(householdMember);
            _context.SaveChanges();
        }

        public HouseholdMember Get(int PersonId)
        {
            return _context.HouseholdMember.FirstOrDefault(p => p.PersonId == PersonId);
        }

        public IEnumerable<HouseholdMember> GetAll()
        {
            return _context.HouseholdMember.ToList();
        }

        public IEnumerable<HouseholdMember> GetAllByHouseholdProfileId(string HouseholdProfileId)
        {
            return _context.HouseholdMember.Where(p => p.HouseholdProfileId == HouseholdProfileId).ToList();
        }

        public Person GetFather(int FatherId)
        {
            return _context.People.FirstOrDefault(p => p.Id == FatherId);
        }

        public Person GetMemberDetail(int PersonId)
        {
            return _context.People.FirstOrDefault(p => p.Id == PersonId);
        }

        public Person GetMother(int MotherId)
        {
            return _context.People.FirstOrDefault(p => p.Id == MotherId);
        }
    }
}

using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public HouseholdMember Get(int Id)
        {
            return _context.HouseholdMember
                .Include(p => p.Person)
                .Include(hp => hp.HouseholdProfile)
                .FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<HouseholdMember> GetAll()
        {
            return _context.HouseholdMember
                .Include(p => p.Person)
                .Include(h => h.HouseholdProfile);
                //.ToList();
        }

        public IEnumerable<HouseholdMember> GetAllByHouseholdProfileId(int householdProfileId)
        {
            return _context.HouseholdMember
                .Include(m => m.Person)
                .Where(p => p.HouseholdProfileId == householdProfileId);
                //.ToList();
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

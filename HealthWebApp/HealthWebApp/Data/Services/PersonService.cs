using System.Collections.Generic;
using System.Linq;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace HealthWebApp.Data.Services
{
    public class PersonService : IPerson
    {
        private ApplicationDbContext _context;
        public PersonService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Person newPerson)
        {
            _context.Add(newPerson);
            _context.SaveChanges();
        }

        public Person Get(int id)
        {
            return Getall().FirstOrDefault(p=>p.Id == id);
            // return _context.People
            //     .Include(a=>a.HouseholdMember)
            //     .Include(a=>a.HouseholdProfile)
            //     .FirstOrDefaultAsync(p => p.Id == id);
        }

        public IEnumerable<Person> Getall()
        {
            return _context.People
                .Include(a=>a.HouseholdMember)
                .Include(a=>a.HouseholdProfile);

        }
    }
}
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

        public IEnumerable<Person> Getall()
        {
            return _context.People
                .Include(a => a.HouseholdProfile)
                .Include(a => a.HouseholdProfile.Barangay)
                .ToList();

        }

        public Person Get(int id)
        {
            return Getall()
                .FirstOrDefault(p => p.Id == id);
        }


    }
}
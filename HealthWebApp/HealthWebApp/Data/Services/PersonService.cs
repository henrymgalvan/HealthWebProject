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
            return _context.People.ToList();
        }

        public Person Get(int id)
        {
            return Getall().FirstOrDefault(p => p.Id == id);
        }

        public void Update(Person UpdatedPerson)
        {
            _context.Entry(UpdatedPerson).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Person person = _context.People.FirstOrDefault(p => p.Id == id);
            _context.People.Remove(person);
            _context.SaveChanges();
         }
    }
}
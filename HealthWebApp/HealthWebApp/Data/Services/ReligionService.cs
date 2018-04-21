using System.Collections.Generic;
using System.Linq;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace HealthWebApp.Data.Services
{
    public class ReligionService : IReligion
    {
        private ApplicationDbContext _context;
        public ReligionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Religion newReligion)
        {
            _context.Add(newReligion);
            _context.SaveChanges();
        }

        public IEnumerable<Religion> Getall()
        {
            return _context.Religion.ToList();
        }

        public Religion Get(int id)
        {
            return Getall().FirstOrDefault(p => p.ReligionId == id);
        }

        public void Update(Religion UpdatedReligion)
        {
            _context.Entry(UpdatedReligion).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            Religion religion = _context.Religion.FirstOrDefault(p => p.ReligionId == Id);
            _context.Religion.Remove(religion);
            _context.SaveChanges();
         }
    }
}
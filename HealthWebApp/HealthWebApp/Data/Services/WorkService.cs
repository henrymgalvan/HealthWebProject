using System.Collections.Generic;
using System.Linq;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace HealthWebApp.Data.Services
{
    public class WorkService : IWork
    {
        private ApplicationDbContext _context;
        public WorkService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Work newWork)
        {
            _context.Add(newWork);
            _context.SaveChanges();
        }

        public IEnumerable<Work> Getall()
        {
            return _context.Work.ToList();
        }

        public Work Get(int Id)
        {
            return Getall().FirstOrDefault(p => p.WorkId == Id);
        }

        public void Update(Work UpdatedWork)
        {
            _context.Entry(UpdatedWork).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Work work = _context.Work.FirstOrDefault(p => p.WorkId == id);
            _context.Work.Remove(work);
            _context.SaveChanges();
         }
    }
}
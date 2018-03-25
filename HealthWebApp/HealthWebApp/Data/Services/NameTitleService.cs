using System.Collections.Generic;
using System.Linq;
using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace HealthWebApp.Data.Services
{
    public class NameTitleService : INameTitle
    {
        private ApplicationDbContext _context;
        public WorkService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(NameTitle newNameTitle)
        {
            _context.Add(newNameTitle);
            _context.SaveChanges();
        }

        public IEnumerable<Work> Getall()
        {
            return _context.NameTitle.ToList();
        }

        public NameTitle Get(int id)
        {
            return Getall().FirstOrDefault(p => p.Id == id);
        }

        public void Update(NameTitle UpdatedNameTitle)
        {
            _context.Entry(UpdatedNameTitle).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            NameTitle nameTitle = _context.Work.FirstOrDefault(p => p.Id == id);
            _context.NameTitle.Remove(nameTitle);
            _context.SaveChanges();
         }
    }
}
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
        public NameTitleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(NameTitle newNameTitle)
        {
            _context.Add(newNameTitle);
            _context.SaveChanges();
        }

        public IEnumerable<NameTitle> Getall()
        {
            return _context.NameTitle.ToList();
        }

        public NameTitle Get(int Id)
        {
            return Getall().FirstOrDefault(p => p.NameTitleId == Id);
        }

        public void Update(NameTitle UpdatedNameTitle)
        {
            _context.Entry(UpdatedNameTitle).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            NameTitle nameTitle = _context.NameTitle.FirstOrDefault(p => p.NameTitleId == Id);
            _context.NameTitle.Remove(nameTitle);
            _context.SaveChanges();
         }
    }
}
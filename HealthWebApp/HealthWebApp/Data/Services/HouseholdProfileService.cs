﻿using HealthWebApp.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp.Data.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace HealthWebApp.Data.Services
{
    public class HouseholdProfileService : IHouseholdProfile
    {
        private ApplicationDbContext _context;
        public HouseholdProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(HouseholdProfile newHouseholdProfile)
        {
            _context.Add(newHouseholdProfile);
            _context.SaveChanges();
        }

        public IEnumerable<HouseholdProfile> GetAll()
        {
            return _context.HouseholdProfile.Include(b => b.Barangay)
                .ToList();
        }

        public IEnumerable<HouseholdProfile> GetallByBarangay(int BarangayId)
        {
            return _context.HouseholdProfile
                .Include(b => b.Barangay)
                .Where(b => b.BarangayId == BarangayId);
        }

        public HouseholdProfile GetById(int id)
        {
            return _context.HouseholdProfile
                .FirstOrDefault(hp => hp.Id == id);
        }

        public HouseholdProfile GetByPersonId(int PersonId)
        {
            throw new NotImplementedException();
        }

        public HouseholdProfile GetByProfileId(string ProfileId)
        {
            return _context.HouseholdProfile
                .FirstOrDefault(hp => hp.ProfileId == ProfileId);
        }

        public void Update(HouseholdProfile updatedHouseholdProfile)
        {
            _context.Entry(updatedHouseholdProfile).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

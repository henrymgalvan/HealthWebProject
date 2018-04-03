using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.EntityModel.Barangays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data
{
    public static class DbInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.PhilArea.Any()) 
            {
                var PhilAreas = new List<PhilArea>()
               {
                   new PhilArea {Name = "Luzon"},
                   new PhilArea {Name = "Visayas"},
                   new PhilArea {Name = "Mindanao"}
               };
               context.PhilArea.AddRange(PhilAreas);
               context.SaveChanges();
            }

            if (!context.Region.Any()) 
            {
                var Regions = new List<Region>()
               {
                   new Region {Name = "1", PhilAreaId = 1},
                   new Region {Name = "2", PhilAreaId = 1},
                   new Region {Name = "3", PhilAreaId = 1}
               };
               context.Region.AddRange(Regions);
               context.SaveChanges();
            }
            
            if (!context.Province.Any()) 
            {
                var Provinces = new List<Province>()
               {
                   new Province {Name = "Pangasinan", RegionId = 1},
                   new Province {Name = "San Fernando", RegionId = 1},
                   new Province {Name = "Ilocos Norte", RegionId = 1}
               };
               context.Province.AddRange(Provinces);
               context.SaveChanges();
            }
            //if (!context.Barangay.Any())
            //{
            //    var barangays = new List<Barangay>()
            //    {
            //        new Barangay {Name = "Bacayao Norte"},
            //        new Barangay {Name = "Bacayao Sur"},
            //        new Barangay {Name = "Barangay I"},
            //        new Barangay {Name = "Barangay II"},
            //        new Barangay {Name = "Barangay IV"},
            //        new Barangay {Name = "Bolosan"},
            //        new Barangay {Name = "Bonuan Binloc"},
            //        new Barangay {Name = "Bonuan Boquig"},
            //        new Barangay {Name = "Bonuan Gueset"},
            //        new Barangay {Name = "Calmay"},
            //        new Barangay {Name = "Carael"},
            //        new Barangay {Name = "Caranglaan"},
            //        new Barangay {Name = "Herrero"},
            //        new Barangay {Name = "Lasip Chico"},
            //        new Barangay {Name = "Lasip Grande"},
            //        new Barangay {Name = "Lomboy"},
            //        new Barangay {Name = "Lucao"},
            //        new Barangay {Name = "Malued"},
            //        new Barangay {Name = "Mamalingling"},
            //        new Barangay {Name = "Mangin"},
            //        new Barangay {Name = "Mayombo"},
            //        new Barangay {Name = "Pantal"},
            //        new Barangay {Name = "Poblacion Oeste"},
            //        new Barangay {Name = "Pogo Chico"},
            //        new Barangay {Name = "Pogo Grande"},
            //        new Barangay {Name = "Pugaro Suit"},
            //        new Barangay {Name = "Salapingao"},
            //        new Barangay {Name = "Salisay"},
            //        new Barangay {Name = "Tambac"},
            //        new Barangay {Name = "Tapuac"},
            //        new Barangay {Name = "Tebeng"},
            //    };
            //    context.Barangay.AddRange(barangays);
            //    context.SaveChanges();
            //}

            if (!context.Religion.Any()) 
            {
                var Religions = new List<Religion>()
               {
                   new Religion {ShortName = "Aglipay"},
                   new Religion {ShortName = "Alliance of Bible Christian Community"},
                   new Religion {ShortName = "Anglican"},
                   new Religion {ShortName = "Anglican"},
                   new Religion {ShortName = "Baptist"},
                   new Religion {ShortName = "Born Again Christian"},
                   new Religion {ShortName = "Buddhism"},
                   new Religion {ShortName = "Catholic"},
                   new Religion {ShortName = "Church of God"},
                   new Religion {ShortName = "Evangelical"},
                   new Religion {ShortName = "Iglesia ni Kristo"},
                   new Religion {ShortName = "Jehovah's Witness"},
                   new Religion {ShortName = "Life Renewal Christian Ministry"},
                   new Religion {ShortName = "Lutheran"},
                   new Religion {ShortName = "Methodist"},
                   new Religion {ShortName = "Islam"},
                   new Religion {ShortName = "Pentecostal"},
                   new Religion {ShortName = "LDS - Mormons"},
                   new Religion {ShortName = "Protestants"},
                   new Religion {ShortName = "Seventh Day Adventist"},
                   new Religion {ShortName = "UCCP"},
                   new Religion {ShortName = "Wesleyan"},
                   new Religion {ShortName = "Christian"}
               };
               context.Religion.AddRange(Religions);
               context.SaveChanges();
            }

            if (!context.Work.Any()) 
            {
                var Works = new List<Work>()
               {
                   new Work {ShortName = "Accountant"},
                   new Work {ShortName = "Actor"}
               };
               context.Work.AddRange(Works);
               context.SaveChanges();
            }

            if (!context.Education.Any()) 
            {
                var Educations = new List<Education>()
               {
                   new Education {ShortName = "Prep"},
                   new Education {ShortName = "Kinder"},
                   new Education {ShortName = "Elementary"},
                   new Education {ShortName = "High School"},
                   new Education {ShortName = "Senior High School"},
                   new Education {ShortName = "Vocational"},
                   new Education {ShortName = "Post Graduate Program"},
                   new Education {ShortName = "Not Applicable"},
                   new Education {ShortName = "No Formal Education"},
                   new Education {ShortName = "Others"},
               };
               context.Education.AddRange(Educations);
               context.SaveChanges();
            }
        }

    }
}

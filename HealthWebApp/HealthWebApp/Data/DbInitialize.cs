using HealthWebApp.Data.EntityModel;
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
            if (!context.Barangay.Any())
            {
                var barangays = new List<Barangay>()
                {
                    new Barangay {Name = "Bacayao Norte"},
                    new Barangay {Name = "Bacayao Sur"},
                    new Barangay {Name = "Barangay I"},
                    new Barangay {Name = "Barangay II"},
                    new Barangay {Name = "Barangay IV"},
                    new Barangay {Name = "Bolosan"},
                    new Barangay {Name = "Bonuan Binloc"},
                    new Barangay {Name = "Bonuan Boquig"},
                    new Barangay {Name = "Bonuan Gueset"},
                    new Barangay {Name = "Calmay"},
                    new Barangay {Name = "Carael"},
                    new Barangay {Name = "Caranglaan"},
                    new Barangay {Name = "Herrero"},
                    new Barangay {Name = "Lasip Chico"},
                    new Barangay {Name = "Lasip Grande"},
                    new Barangay {Name = "Lomboy"},
                    new Barangay {Name = "Lucao"},
                    new Barangay {Name = "Malued"},
                    new Barangay {Name = "Mamalingling"},
                    new Barangay {Name = "Mangin"},
                    new Barangay {Name = "Mayombo"},
                    new Barangay {Name = "Pantal"},
                    new Barangay {Name = "Poblacion Oeste"},
                    new Barangay {Name = "Pogo Chico"},
                    new Barangay {Name = "Pogo Grande"},
                    new Barangay {Name = "Pugaro Suit"},
                    new Barangay {Name = "Salapingao"},
                    new Barangay {Name = "Salisay"},
                    new Barangay {Name = "Tambac"},
                    new Barangay {Name = "Tapuac"},
                    new Barangay {Name = "Tebeng"},
                };
                context.Barangay.AddRange(barangays);
                context.SaveChanges();
            }


        }

    }
}

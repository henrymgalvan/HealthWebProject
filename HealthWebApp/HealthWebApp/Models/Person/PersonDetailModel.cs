using System;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Models.Person
{
    public class PersonDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }    
        public string ExtensionName { get; set; }   
        public string DateOfBirth { get; set; }
        public string Sex { get; set; }

        public string NameTittle { get; set; }

        public string ContactNumber { get; set; }

        public string Address { get; set; }
        public string Barangay { get; set; }

        public string HouseholdProfileId { get; set; }



    }
}
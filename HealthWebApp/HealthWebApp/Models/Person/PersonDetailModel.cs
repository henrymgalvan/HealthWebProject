using System;
using HealthWebApp.Data.EntityModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Models.Person
{
    public class PersonDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }    
        public string ExtensionName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:mm-dd-yyyy}")]
        public string DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string CivilStatus { get; set; }
        public string NameTitle { get; set; }
        public string ContactNumber { get; set; }
        public string Barangay { get; set; }
    }
}
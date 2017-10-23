using HealthWebApp.Data.EntityModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Models.Person
{
    public class PersonCreateModel
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string NameTitle { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Extension")]
        public string ExtensionName { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Gender")]
        public Gender Sex { get; set; }
        [Display(Name = "Civil Status")]
        public CivilStatus CivilStatus { get; set; }


        public string ContactNumber { get; set; }

        public string Address { get; set; }
        public Barangay Barangay { get; set; }

        public string HouseholdProfileId { get; set; }
    }
}

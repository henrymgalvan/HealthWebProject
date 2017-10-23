using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.Person
{
    public class PersonEditModel
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string NameTitle { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string  MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Extension")]
        public string ExtensionName { get; set; }
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
        [Display(Name = "Gender")]
        public string Sex { get; set; }
        [Display(Name = "Civil Status")]
        public string CivilStatus { get; set; }


        public string ContactNumber { get; set; }

        public string Address { get; set; }
        public string Barangay { get; set; }

        public string HouseholdProfileId { get; set; }
    }
}

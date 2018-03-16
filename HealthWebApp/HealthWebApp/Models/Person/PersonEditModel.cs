using HealthWebApp.Data.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Models.Person
{
    public class PersonEditModel
    {
        public long Id { get; set; }
        public int NameTitleId {get; set;}
        public string NameTitle { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string  MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Extension")]
        public ExtensionName ExtensionName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Gender")]
        public Gender Sex { get; set; }
        [Display(Name = "Civil Status")]
        public CivilStatus CivilStatus { get; set; }
        [Display(Name = "Contact #")]
        [Phone]
        public string ContactNumber { get; set; }
    }
}

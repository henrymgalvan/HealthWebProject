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

        public int NameTitleId { get; set; }

        [Required, StringLength(30), MinLength(1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]   //First letter is capital, remaining characters is alphabetical
        public string FirstName { get; set; }

        [Required, StringLength(30)]
        public string MiddleName { get; set; }

        [Required, StringLength(30)]
        public string LastName { get; set; }

        public ExtensionName ExtensionName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        public Gender Sex { get; set; }
        
        public CivilStatus CivilStatus { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public int WorkId { get; set; }

//        public virtual HouseholdMember HouseholdMember { get; set; }
        
        public long PhilHealthId { get; set; }

        public int ReligionId { get; set; }

        public long FatherId { get; set; }
//        public virtual Person Father { get; set; }

        public long MotherId { get; set; }
//        public virtual Person Mother { get; set; }

        public bool PersonConsent { get; set; } //Consent of patient to digital storage

        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
//        public long EmployeeId { get; set; }    //Updated by Last Employee

    }
}

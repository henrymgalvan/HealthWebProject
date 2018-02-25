using HealthWebApp.Data.EntityModel.Admin;
using HealthWebApp.Data.EntityModel.Household;
using HealthWebApp.Data.EntityModel.PhilHealthFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel
{
    public enum Gender
    {
        Male = 1, Female = 2
    }

    public enum CivilStatus
    {
        Single = 1, Married, LiveIn, Separated, Annuled, Widow
    }

    public class Person
    {
        [Key]
        public long Id { get; set; }

        [StringLength(30)]
        public string NameTitle { get; set; } 

        [Required, StringLength(30), MinLength(1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]   //First letter is capital, remaining characters is alphabetical
        public string FirstName { get; set; }

        [Required, StringLength(30)]
        public string MiddleName { get; set; }

        [Required, StringLength(30)]
        public string LastName { get; set; }

        [StringLength(3)]
        public string ExtensionName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        public Gender Sex { get; set; }

        public CivilStatus CivilStatus { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual HouseholdMember HouseholdMember { get; set; }
        public ICollection<PhilHealth> PhilHealth { get; set; }
        public Religion Religion { get; set; }

        public long FatherId { get; set; }
        public virtual Person Father { get; set; }

        public long MotherId { get; set; }
        public virtual Person Mother { get; set; }

        public bool PersonConsent { get; set; } //Consent of patient to digital storage
        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public long EmployeeId { get; set; }

        public string FullName => (FirstName + " " + MiddleName + " " + LastName + " " + ExtensionName);
    }
}
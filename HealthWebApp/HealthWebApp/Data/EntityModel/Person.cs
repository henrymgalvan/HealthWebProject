using HealthWebApp.Data.EntityModel.Admin;
using HealthWebApp.Data.EntityModel.Household;
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
        Single =1, Married, LiveIn, Separated, Annuled, Widow
    }

    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30), MinLength(1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]   //First letter is capital, remaining characters is alphabetical
        public string FirstName { get; set; }

        [Required, StringLength(30)]
        public string MiddleName { get; set; }

        [Required, StringLength(30)]
        public string LastName { get; set; }

        [StringLength(3)]
        public string ExtensionName { get; set; }

        [StringLength(30)]
        public string NameTitle { get; set; }

        public Gender Sex { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        public CivilStatus CivilStatus { get; set; }

        [Phone]
        public string ContactNumber { get; set; }

        public bool PersonConsent { get; set; } //Consent of patient to digital storage
        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual HouseholdMember HouseholdMember { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee AssignedBy { get; set; }

        public string FullName => (FirstName + " " + MiddleName + " " + LastName);
    }
}
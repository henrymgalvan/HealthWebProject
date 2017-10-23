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
        Dependent = 1, Single, Married, LiveIn, Separated, Annuled, Widowed
    }

    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30), MinLength(1)]
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
        public DateTime? DateOfBirth { get; set; }

        public CivilStatus CivilStatus { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
        public bool PersonConsent { get; set; } //Consent of patient to digital storage


        public int HouseholdProfileId { get; set; }
        public virtual HouseholdProfile HouseholdProfile { get; set; }

    }
}
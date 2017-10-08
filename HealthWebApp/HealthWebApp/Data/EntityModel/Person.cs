using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp.Data.EntityModel
{
    public class Person
    {
        public enum Gender
        {
            Male = 1, Female = 2
        }


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
        public string NameTittle { get; set; }

        public Gender Sex { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
        public bool PersonConsent { get; set; } //Consent of patient to digital storage

        public HouseholdProfile HouseholdProfile {get; set;}
        public FamilyProfile FamilyProfile { get; set; }

    }
}
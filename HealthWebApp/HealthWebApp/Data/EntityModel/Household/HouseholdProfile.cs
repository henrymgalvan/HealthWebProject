using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HealthWebApp.Data.EntityModel.Barangays;
using HealthWebApp.Data.EntityModel.GeoTagging;

namespace HealthWebApp.Data.EntityModel.Household
{
    public class HouseholdProfile
    {
        [Key]
        public int Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public int BarangayId { get; set; }
        public virtual Barangay Barangay { get; set; }

        public string Note { get; set; }
        //public int GeotagId { get; set; }
        //public virtual GeoTag Geotag { get; set; }
        public virtual IEnumerable<HouseholdMember> HouseholdMembers { get; set; }
        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
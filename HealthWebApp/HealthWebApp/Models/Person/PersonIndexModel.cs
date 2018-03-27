using System.Collections.Generic;

namespace HealthWebApp.Models.Person
{
    public class PersonIndexModel
    {
        public IEnumerable<PersonDetailModel> People {get; set;}
    }
}
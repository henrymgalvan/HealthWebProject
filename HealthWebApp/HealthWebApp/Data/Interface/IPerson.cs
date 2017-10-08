using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface IPerson
    {
        IEnumerable<Person> Getall();
        Person Get(int id);
        void Add(Person newPerson);
        
         
    }
}
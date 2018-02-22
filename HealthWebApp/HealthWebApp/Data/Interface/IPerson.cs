using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface IPerson
    {
        IEnumerable<Person> Getall();
        Person Get(long id);
        void Add(Person newPerson);
        void Update(Person updatedPerson);
        void Delete(long id);
         
    }
}
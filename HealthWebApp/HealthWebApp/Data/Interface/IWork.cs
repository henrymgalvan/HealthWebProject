using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface IWork
    {
        IEnumerable<Work> Getall();
        Work Get(int Id);
        void Add(Work newWork);
        void Update(Work updatedWork);
        void Delete(int Id);
         
    }
}
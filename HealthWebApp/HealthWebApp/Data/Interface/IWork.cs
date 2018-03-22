using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface IWork
    {
        IEnumerable<IWork> Getall();
        Work Get(int id);
        void Add(Work newWork);
        void Update(Work updatedWork);
        void Delete(int id);
         
    }
}
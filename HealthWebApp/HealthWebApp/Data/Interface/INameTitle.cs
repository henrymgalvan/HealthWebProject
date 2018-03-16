using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface INameTitle
    {
        IEnumerable<INameTitle> Getall();
        NameTitle Get(int id);
        void Add(NameTitle newNameTitle);
        void Update(NameTitle updatedNameTitle);
        void Delete(int id);
         
    }
}
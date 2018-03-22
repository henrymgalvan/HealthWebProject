using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface IReligion
    {
        IEnumerable<IReligion> Getall();
        Religion Get(int id);
        void Add(Religion newReligion);
        void Update(NameTitle updatedReligion);
        void Delete(int id);
    }
}

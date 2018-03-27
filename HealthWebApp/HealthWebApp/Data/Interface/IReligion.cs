using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp.Data.EntityModel;

namespace HealthWebApp.Data.Interface
{
    public interface IReligion
    {
        IEnumerable<Religion> Getall();
        Religion Get(int Id);
        void Add(Religion newReligion);
        void Update(Religion updatedReligion);
        void Delete(int Id);
    }
}

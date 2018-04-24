using HealthWebApp.Data.EntityModel.PhilHealthFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.Interface
{
    public interface IPhilHealth
    {
        IEnumerable<PhilHealth> Getall();
        PhilHealth Get(long Id);
        void Add(PhilHealth newPhilHealth);
        void Update(PhilHealth updatedPhilHealth);
        void Delete(long Id);

    }
}

using HealthWebApp.Data.EntityModel;
using HealthWebApp.Data.EntityModel.Barangays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp.Data.Interface
{
    public interface IBarangay
    {
        IEnumerable<Barangay> GetAll();
        Barangay GetBarangayById(int id);
    }
}

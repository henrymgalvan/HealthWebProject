using System;
using System.Collections.Generic;
using HealthWebApp.Data.EntityModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthWebApp.Data.Interface
{
    public interface INameTitle
    {
        IEnumerable<NameTitle> Getall();
        NameTitle Get(int Id);
        void Add(NameTitle newNameTitle);
        void Update(NameTitle updatedNameTitle);
        void Delete(int Id);
    }
}
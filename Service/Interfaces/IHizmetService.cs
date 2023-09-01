using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IHizmetService
    {
        IList<Hizmet> GetList();

        void Add(Hizmet hizmet );

        void Update(Hizmet hizmet);

        void Remove(Hizmet hizmet);

        Hizmet GetById(int id);
    }
}

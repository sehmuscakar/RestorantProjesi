using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IAboutService
    {
        IList<About> GetList();

        void Add(About about);

        void Update(About about);

        void Remove(About about);

        About GetById(int id);
    }
}

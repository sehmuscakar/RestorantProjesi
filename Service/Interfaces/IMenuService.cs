using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IMenuService
    {
        IList<Menu> GetList();

        void Add(Menu menu);

        void Update(Menu menu);

        void Remove(Menu menu);

        Menu GetById(int id);
    }
}

using Repository.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
   public interface ITeamService
    {

        IList<Team> GetList();

        void Add(Team team);

        void Update(Team team);

        void Remove(Team team);

       Team GetById(int id);
    }
}

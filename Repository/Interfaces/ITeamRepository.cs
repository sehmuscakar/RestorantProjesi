using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
   public interface ITeamRepository: IEntityRepository<Team>
    {

    }
}

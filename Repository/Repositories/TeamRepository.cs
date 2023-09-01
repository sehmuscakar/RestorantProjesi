using Core.DataAccess.EntityFramework;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
 public class TeamRepository:BaseRepository<Team,ProjeContext>,ITeamRepository
    {


    }
}

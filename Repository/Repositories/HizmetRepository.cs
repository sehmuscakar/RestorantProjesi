using Core.DataAccess.EntityFramework;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Context
{
    public class HizmetRepository:BaseRepository<Hizmet,ProjeContext>,IHizmetRepository
    {

    }
}

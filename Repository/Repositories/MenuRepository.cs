using Core.DataAccess.EntityFramework;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories.Context;
namespace Repository.Repositories
{
    public class MenuRepository:BaseRepository<Menu,ProjeContext>,IMenuRepository
    {

    }
}

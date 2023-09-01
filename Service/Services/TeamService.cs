using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TeamService : ITeamService
    {
        ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public void Add(Team team)
        {

          
            _teamRepository.Add(team);
        }

        public Team GetById(int id)
        {
            Expression<Func<Team, bool>> filter = x => x.Id == id;
            return _teamRepository.Get(filter);
        }

        public IList<Team> GetList()
        {
            var data = _teamRepository.GetActiveList();
            return data;
        }

        public void Remove(Team team)
        {
           _teamRepository.Delete(team);
        }

        public void Update(Team team)
        {
            team.UpdatedAt= DateTime.Now;
         _teamRepository.Update(team);
        }
    }
}

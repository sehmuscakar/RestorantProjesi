using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System.Linq.Expressions;

namespace Service.Services
{
    public class HizmetService : IHizmetService
    {
        IHizmetRepository _hizmetRepository;
       
        public HizmetService(IHizmetRepository hizmetRepository)
        {
            _hizmetRepository = hizmetRepository;
       
        }

        public void Add(Hizmet hizmet)
        {
         
            _hizmetRepository.Add(hizmet);
        }

        public Hizmet GetById(int id)
        {
            Expression<Func<Hizmet, bool>> filter = x => x.Id == id;
            return _hizmetRepository.Get(filter);
        }

        public IList<Hizmet> GetList()
        {
            var data = _hizmetRepository.GetActiveList();
            return data;
        }

        public void Remove(Hizmet hizmet)
        {
           _hizmetRepository.Delete(hizmet);
        }

        public void Update(Hizmet hizmet)
        {
            hizmet.UpdatedAt = DateTime.Now;
            _hizmetRepository.Update(hizmet);
        }
    }
}

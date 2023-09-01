using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System.Linq.Expressions;

namespace Service.Services
{
    public class AboutService : IAboutService
    {
        IAboutRepository _aboutRepository;

        public AboutService(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void Add(About about)
        {
      
            _aboutRepository.Add(about);
        }

        public About GetById(int id)
        {
            Expression<Func<About, bool>> filter = x => x.Id == id;
            return _aboutRepository.Get(filter);
        }

        public IList<About> GetList()
        {
            var data = _aboutRepository.GetActiveList();
            return data;
        }
        public void Remove(About about)
        {
          
          _aboutRepository.Delete(about);
        }

        public void Update(About about)
        {
            about.UpdatedAt = DateTime.Now;
            _aboutRepository.Update(about);
        }
    }
}

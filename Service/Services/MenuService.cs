using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System.Linq.Expressions;

namespace Service.Services
{
    public class MenuService : IMenuService
    {

        IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public void Add(Menu menu)
        {
         
           _menuRepository.Add(menu);
        }

        public Menu GetById(int id)
        {
            Expression<Func<Menu, bool>> filter = x => x.Id == id;
            return _menuRepository.Get(filter);
        }

        public IList<Menu> GetList()
        {
            var data = _menuRepository.GetActiveList();
            return data;
        }

        public void Remove(Menu menu)
        {
           _menuRepository.Delete(menu);
        }

        public void Update(Menu menu)
        {
            menu.UpdatedAt = DateTime.Now;
            _menuRepository.Update(menu);
        }
    }
}

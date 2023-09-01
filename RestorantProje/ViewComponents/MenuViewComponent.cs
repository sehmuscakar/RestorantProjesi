using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace RestorantProje.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        IMenuService _menuService;

        public MenuViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_menuService.GetList());
        }
    }
}

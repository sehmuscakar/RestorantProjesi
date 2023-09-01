using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace RestorantProje.ViewComponents
{
    public class HizmetViewComponent:ViewComponent
    {
        IHizmetService _hizmetService;

        public HizmetViewComponent(IHizmetService hizmetService)
        {
            _hizmetService = hizmetService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_hizmetService.GetList());
        }
    }
}

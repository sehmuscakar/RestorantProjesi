using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace RestorantProje.ViewComponents
{
    public class KurumsalViewComponent:ViewComponent
    {
        IAboutService _aboutService;

        public KurumsalViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_aboutService.GetList());
        }
    }
}

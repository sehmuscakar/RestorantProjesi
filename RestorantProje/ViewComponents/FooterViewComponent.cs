using Microsoft.AspNetCore.Mvc;

namespace RestorantProje.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}

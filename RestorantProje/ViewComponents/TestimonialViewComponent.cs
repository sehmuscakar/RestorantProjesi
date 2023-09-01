using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace RestorantProje.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        ITestimonialService _testimonialService;

        public TestimonialViewComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_testimonialService.GetList());
        }

    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Service.Interfaces;
using Service.Services;

namespace RestorantProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
 
    public class TestimonialController : Controller
    {

        ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        // GET: TestimonialController
        public ActionResult Index()
        {

            return View(_testimonialService.GetList());
        }

        // GET: TestimonialController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestimonialController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestimonialController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Testimonial testimonial,IFormFile? Image)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Image is not null)
                    {
                        string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                        using var stream = new FileStream(klasor, FileMode.Create);//klasor buraya yukle ,FileMode.Create ekleme işlemi olduğu belirtisi
                        Image.CopyTo(stream);// dosya yuklendi
                       testimonial.Image = Image.FileName; //burda da veritabanına atadı propert olarak tanımladığı kısıma db de 
                    }
                    _testimonialService.Add(testimonial);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialController/Edit/5
        public ActionResult Edit(int id)
        {
            var data=_testimonialService.GetById(id);
            return View(data);
        }

        // POST: TestimonialController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Testimonial testimonial, IFormFile? Image)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Image is not null)
                    {
                        string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                        using var stream = new FileStream(klasor, FileMode.Create);
                        Image.CopyTo(stream);
                        testimonial.Image = Image.FileName; 
                    }
                    _testimonialService.Update(testimonial);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TestimonialController/Delete/5
        public ActionResult Delete(int id)
        {

            var data = _testimonialService.GetById(id);
            return View(data);
        }

        // POST: TestimonialController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Testimonial testimonial)
        {
            try
            {
                _testimonialService.Remove(testimonial);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

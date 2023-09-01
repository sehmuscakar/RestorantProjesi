using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Service.Interfaces;
namespace RestorantProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
  
    public class AboutController : Controller
    {

        IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        // GET: AboutController
        public ActionResult Index()
        {
            var abouts = _aboutService.GetList();
            return View(abouts);
        }

        // GET: AboutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AboutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(About about, IFormFile? Image1, IFormFile? Image2, IFormFile? Image3, IFormFile? Image4)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Image1 is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image1.FileName;
                        string klasor2 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image2.FileName;
                        string klasor3 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image3.FileName;
                        string klasor4 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image4.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create); 
                        using var stream2 = new FileStream(klasor2, FileMode.Create); 
                        using var stream3 = new FileStream(klasor3, FileMode.Create); 
                        using var stream4 = new FileStream(klasor4, FileMode.Create); 
                        Image1.CopyTo(stream1);
                        Image2.CopyTo(stream2);
                        Image3.CopyTo(stream3);
                        Image4.CopyTo(stream4);
                        about.Image1 = Image1.FileName; 
                        about.Image2 = Image2.FileName;
                        about.Image3 = Image3.FileName;
                        about.Image4 = Image4.FileName;
                    }
                    _aboutService.Add(about);

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Edit/5
        public ActionResult Edit(int id)
        {
            var data=_aboutService.GetById(id);
            return View(data);
        }

        // POST: AboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]//olması gerekl validayonlar eğer olur ekleme olur bunun saayesinde yoksa eklemmez
        public ActionResult Edit(int id, About about, IFormFile? Image1, IFormFile? Image2, IFormFile? Image3, IFormFile? Image4)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    if (Image1 is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image1.FileName;
                        string klasor2 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image2.FileName;
                        string klasor3 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image3.FileName;
                        string klasor4 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image4.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        using var stream2 = new FileStream(klasor2, FileMode.Create);
                        using var stream3 = new FileStream(klasor3, FileMode.Create);
                        using var stream4 = new FileStream(klasor4, FileMode.Create);
                        Image1.CopyTo(stream1);
                        Image2.CopyTo(stream2);
                        Image3.CopyTo(stream3);
                        Image4.CopyTo(stream4);
                        about.Image1 = Image1.FileName;
                        about.Image2 = Image2.FileName;
                        about.Image3 = Image3.FileName;
                        about.Image4 = Image4.FileName;
                    }
                    _aboutService.Update(about);
                }

              return  RedirectToAction("Index");
            }
          
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _aboutService.GetById(id);
            return View(data);
        }

        // POST: AboutController/Delete/5
        [HttpPost]
      
        public ActionResult Delete(int id, About about)
        {
            try
            {
                _aboutService.Remove(about);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

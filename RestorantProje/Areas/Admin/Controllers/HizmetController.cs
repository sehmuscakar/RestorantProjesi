using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Service.Interfaces;

namespace RestorantProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class HizmetController : Controller
    {
        IHizmetService _hizmetService;

        public HizmetController(IHizmetService hizmetService)
        {
            _hizmetService = hizmetService;
        }

        // GET: ServiceController
        public ActionResult Index()
        {
          
            return View(_hizmetService.GetList());
        }

        // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hizmet hizmet, IFormFile? Image)
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
                        hizmet.Image = Image.FileName; //burda da veritabanına atadı propert olarak tanımladığı kısıma db de 
                    }
                    _hizmetService.Add(hizmet);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            var data= _hizmetService.GetById(id);
            return View(data);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hizmet hizmet, IFormFile? Image)
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
                        hizmet.Image = Image.FileName; 
                    }
                    _hizmetService.Update(hizmet);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _hizmetService.GetById(id);
            return View(data);

        }

        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Hizmet hizmet)
        {
            try
            {
                _hizmetService.Remove(hizmet);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

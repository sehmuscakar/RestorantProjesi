using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Service.Interfaces;
using Service.Services;

namespace RestorantProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
 
    public class MenuController : Controller
    {
        IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: MenuController
        public ActionResult Index()
        {

            return View(_menuService.GetList());
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu menu, IFormFile? Image)
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
                        menu.Image = Image.FileName; 
                    }
                    _menuService.Add(menu);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View(_menuService.GetById(id));
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Menu menu, IFormFile? Image)
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
                        menu.Image = Image.FileName; 
                    }
                    _menuService.Update(menu);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(_menuService.GetById(id));
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Menu menu)
        {
            try
            {
                _menuService.Remove(menu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

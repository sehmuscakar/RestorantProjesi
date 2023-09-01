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
 
    public class TeamController : Controller
    {
        ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        // GET: TeamController
        public ActionResult Index()
        {
          
            return View(_teamService.GetList());
        }

        // GET: TeamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Team team, IFormFile? Image)
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
                       team.Image = Image.FileName;
                    }
                   _teamService.Add(team);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = _teamService.GetById(id);

            return View(data);
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Team team, IFormFile? Image)
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
                        team.Image = Image.FileName;
                    }
                    _teamService.Update(team);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Delete/5
        public ActionResult Delete(int id)
        {
            var data=_teamService.GetById(id);

            return View(data);
        }

        // POST: TeamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Team team)
        {
            try
            {
                _teamService.Remove(team);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

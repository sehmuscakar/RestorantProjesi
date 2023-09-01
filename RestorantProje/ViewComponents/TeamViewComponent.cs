using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace RestorantProje.ViewComponents
{
    public class TeamViewComponent:ViewComponent
    {
        ITeamService _teamService;

        public TeamViewComponent(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_teamService.GetList());
        }
    }
}

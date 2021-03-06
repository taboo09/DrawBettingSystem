using System.Threading.Tasks;
using BetSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BetSystem.ViewComponents
{
    public class SelectedSeason : ViewComponent
    {
        private readonly ISeasonRepository seasonRepo;

        public SelectedSeason(ISeasonRepository seasonRepo)
        {
            this.seasonRepo = seasonRepo;
        }
        public async Task<IViewComponentResult> InvokeAsync(string title, string subTitle, string info)
        {
            var season = await seasonRepo.IsSelected();

            ViewBag.Title = title;
            ViewBag.SubTitle = subTitle;
            ViewBag.Info = info;

            return View(season);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext c = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = c.Experiences.ToList();
            return View(values);
        }
    }
}

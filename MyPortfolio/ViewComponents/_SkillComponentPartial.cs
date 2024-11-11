using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext c = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = c.Skills.ToList();
            return View(values);
        }
    }
}

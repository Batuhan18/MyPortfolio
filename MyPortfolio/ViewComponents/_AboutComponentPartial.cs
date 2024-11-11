using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext contex=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=contex.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.subDesc=contex.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=contex.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}

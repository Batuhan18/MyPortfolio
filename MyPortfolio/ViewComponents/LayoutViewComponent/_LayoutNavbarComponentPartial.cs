using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponent
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount=context.toDoLists.Where(x=>x.Status==false).Count();
            var values=context.toDoLists.Where(x=>x.Status==false).ToList();
            return View(values);
        }
    }
}

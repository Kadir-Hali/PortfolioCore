using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        Random rnd = new Random();
        public IViewComponentResult Invoke()
        {
            ViewBag.v0 = context.Testimonials.Count();
            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = context.Skills.Count();
            ViewBag.v3 = rnd.Next(10,21);
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class CategoryController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}

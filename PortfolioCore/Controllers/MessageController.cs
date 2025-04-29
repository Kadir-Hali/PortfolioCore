using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

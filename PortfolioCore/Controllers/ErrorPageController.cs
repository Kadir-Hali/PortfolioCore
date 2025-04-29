using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        [Route("ErrorPage/Page404")]
        public IActionResult Page404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Models;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var socialMedia = context.SocialMedias.ToList();
            var workField = context.WorkFields.Select(x => x.WorkFieldName).ToList();

            var model = new DefaultFeatureViewModel()
            {
                SocialMedias = socialMedia,
                WorkFields = workField
            };
            return View(model);
        }
    }
}

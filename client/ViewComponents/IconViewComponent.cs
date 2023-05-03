using client.Models;
using client.Utils;
using Microsoft.AspNetCore.Mvc;

namespace client.ViewComponents
{
    public class IconViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Size? width)
        {
            var viewModel = new IconViewModel();

            if (width == null)
                viewModel.Width = Size.Sm;

            return View(viewModel);
        }
    }
}

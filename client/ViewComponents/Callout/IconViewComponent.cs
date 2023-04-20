using client.Models;
using Microsoft.AspNetCore.Mvc;

namespace client.ViewComponents.Callout
{
    public class IconViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {
			IconViewModel viewModel = new IconViewModel{2};
         
            if(message == null)
            {
                viewModel = 2;
            }


            return View(viewModel);
        }
    }
}
